using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace QuanLyCanHo_demo
{
    public partial class mainForm : Form
    {
        private SerialPort RFID; // biến đại diện RFID
        private string DataString; // biến chứa dữ liệu đọc từ RFID 
        private string tabname; // biến chứa tên tab 


        public mainForm()
        {
            InitializeComponent();
        }

        

        /*private void mainForm_Load()
        {
            RFID = new SerialPort();
            RFID.PortName = "COM8";
            RFID.BaudRate = 9600;
            RFID.DataBits = 8;
            RFID.Parity = Parity.None;
            RFID.StopBits = StopBits.One;
            RFID.Open();
            RFID.ReadTimeout = 200;
            if (RFID.IsOpen)
            {
                //RFID.Close();
                MessageBox.Show("Connect success");
                DataString = "";
            }
            else
            {
                MessageBox.Show("Connect to the ID reader");
                RFID.Close();
            }
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);
        }*/
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            // kết nối với Arduino RFID reader
            RFID = new SerialPort();
            RFID.PortName = "COM8";
            RFID.BaudRate = 9600;
            RFID.DataBits = 8;
            RFID.Parity = Parity.None;
            RFID.StopBits = StopBits.One;

            RFID.Open();
            RFID.ReadTimeout = 200;

            if (RFID.IsOpen)
            {
                DataString = "";
            }
            else
            {
                MessageBox.Show("Connect to the ID reader");
                RFID.Close();
            }
            //Nhận dữ liệu từ arduino
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);
        }

        // xử lý dữ liệu nhận được
        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // lưu dữ liệu nhận được vào biến DataString
            DataString = RFID.ReadExisting();

            // gọi đến function DisplayText để hiện lên textbox
            this.Invoke(new EventHandler(DisplayText));
        }

        private void qlchtabControl_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            // lấy tab name của tab đang được chọn
            tabname = this.qlchtabControl.SelectedTab.Name;
        }

        private void DisplayText(object sender, EventArgs e)
        {
            // dựa vào tabname đang được chọn để đưa data lên đúng text box
            if (tabname == "tabCardManage")
            {
                boxCardID.AppendText(DataString);               
            }                
            else if (tabname == "tabAddGuest")
            {
                boxCardGiveGuest.AppendText(DataString);
            }
                
        }




        //Quản lý thẻ
        //-------------------------------------------------------------------------------------------------------------------------

        // tìm tất cả thẻ đang quản lý
        private void btnSearchAllCardID_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            // chọn tất cả thông tin của thẻ và Room mà thẻ đăng thuộc về
            string query = "select card.*,roomscardsvalid.RoomID,guest_hold_card.CMND from card,roomscardsvalid,guest_hold_card where card.ID = roomscardsvalid.CardID AND card.ID = guest_hold_card.Card AND guest_hold_card.Status = '1'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                CardGridView.DataSource = dt;
            }
        }

            // tìm thẻ theo ID
        private void btnSearchCardId_Click(object sender, EventArgs e)
        {
            
            String cid = boxCardID.Text;

            DataTable dt = new DataTable();
            // chọn thông tin của thẻ có ID = cid và Room mà thẻ đăng thuộc về
            string query = "select card.*,roomscardsvalid.RoomID,guest_hold_card.CMND from card,roomscardsvalid,guest_hold_card where card.ID = roomscardsvalid.CardID AND card.ID = guest_hold_card.Card AND guest_hold_card.Status = '1' AND ID = '" + cid+"'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                CardGridView.DataSource = dt;
            }
        }

            // thêm thẻ mới vào
        private void btnAddCardID_Click(object sender, EventArgs e)
        {
            String cid = boxCardID.Text;
            //String rid = box

            DataTable dt = new DataTable();
            // kiểm tra thẻ đã tồn tại trong cơ sở dữ liệu hay chưa
            string queryx = "select * from card  where ID = '"+cid+"'";
            // thêm vào bảng card thẻ có ID = cid
            string query = "insert into card (ID) values ('" + cid + "')";
            // thêm vào bảng roomscardsvalid thẻ có ID = cid và để căn hộ mặc định = un_use, tức là thẻ mới được thêm vào và chưa dùng cho phòng nào
            string query1 = "insert into roomscardsvalid (CardID) values ('" + cid + "')";
            // thêm vào bảng guest_hold_card thẻ có vị khách ẩn danh x
            string query2 = "insert into guest_hold_card (Card) values ('" + cid + "')";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                //con.Open();

                //MySqlDataAdapter da = new MySqlDataAdapter(queryx, con);

                //da.Fill(dt);
                //con.Close();
                //if (dt.Rows.Count < 1)
                //{
                    // thêm thẻ vào bảng card trước để thỏa mãn khóa ngoại
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    con.Close();

                    // thêm thẻ vào bảng roomscardsvalid 
                    con.Open();
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    con.Close();

                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();


                    MessageBox.Show("Card saved");

                //}
                //else
                //{
                    //MessageBox.Show("This card already have.");
                //}

                
                
            }
        }

            // thay đổi phòng thẻ thuộc về
        private void button1_Click(object sender, EventArgs e)
        {
            String cid = boxCardID.Text;
            String rid = boxCardsRoom.Text;
            //String sid = boxCardStatus.Text;

            DataTable dt = new DataTable();
            // cập nhật lại trong bảng roomscardsvalid thông tin căn hộ mà thẻ thuộc về
            string query = "update roomscardsvalid set RoomID = '"+rid+"' where CardID = '"+cid+"'";
            // cập nhật laị trạng thái của thẻ là đang được sử dụng bởi 1 phòng nào đó 
            string query1 = "UPDATE card SET Status='1' WHERE ID = " + cid + "";
            // cập nhật lại thẻ ko sử dụng
            string query2 = "UPDATE card SET Status='0' WHERE ID = " + cid + "";


            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                // cập nhật bảng roomscardsvalid
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();
                // cập nhật bảng card
                con.Open();
                if (rid == "un_use")
                {
                    MySqlCommand cmd1 = new MySqlCommand(query2, con);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                }
                else
                {
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                }

                MessageBox.Show("Add room success");
            }
        }

            // thay đổi status thẻ
        /*private void btnChangeCardID_Click(object sender, EventArgs e)
        {
            String cid = boxCardID.Text;
            String sid = boxCardStatus.Text;

            DataTable dt = new DataTable();

            string query = "UPDATE card SET Status='"+sid+"' WHERE ID = "+cid+"";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                //MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                //da.Fill(dt);
                //dataGridView1.DataSource = dt;

                MessageBox.Show("Card changed");
            }
        }*/


            // xóa thẻ ~ thay đổi status = 2
        private void btnDelCardID_Click(object sender, EventArgs e)
        {
            String cid = boxCardID.Text;
            //String sid = boxCardStatus.Text;

            DataTable dt = new DataTable();
            // cập nhật lại bảng roomscardsvalid thông tin thẻ là un_use
            string query = "update roomscardsvalid set RoomID = 'un_use' where CardID = '" + cid + "'";
            // cập nhật lại bảng card thông tin của thẻ là đã xóa ~ status = 2
            string query1 = "UPDATE card SET Status='2' WHERE ID = " + cid + "";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();
                //MessageBox.Show(cid.Trim());
                con.Open();
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                MySqlDataReader reader1 = cmd1.ExecuteReader();


                MessageBox.Show("Card deleted");
            }
        }


        // clear các ô text box
        private void btnCardIDClear_Click(object sender, EventArgs e)
        {
            boxCardID.Clear();
            boxCardsRoom.Clear();
            boxCardsGuest.Clear();
            boxCardStatus.Clear();
        }

        // nhấp vào ô và lấy thông tin

        string IDKey;

        private void CardGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CardGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                IDKey = CardGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            

            DataTable dt = new DataTable();
            
            string query = "select card.*,roomscardsvalid.RoomID,guest_hold_card.CMND from card,roomscardsvalid,guest_hold_card where card.ID = roomscardsvalid.CardID AND card.ID = guest_hold_card.Card AND guest_hold_card.Status = '1' AND card.ID = '" + IDKey +"'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                //CardGridView.DataSource = dt;
            }

            boxCardID.Text = dt.Rows[0][0].ToString();
            boxCardsRoom.Text = dt.Rows[0][2].ToString();
            boxCardsGuest.Text = dt.Rows[0][3].ToString();
            boxCardStatus.Text = dt.Rows[0][1].ToString();
        }




        //Quản lý căn hộ
        //-------------------------------------------------------------------------------------------------------------------------

        // thêm căn hộ
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            String rid = boxRoomID.Text;
            String rtype = boxRoomType.SelectedItem.ToString();
            

            DataTable dt = new DataTable();
                // thêm phòng
            string query = "INSERT INTO roominfo (RoomID, RoomType) VALUES ('"+rid+ "','" + rtype + "')";
            // thêm ng khách room
            string query1 = "INSERT INTO guest (CMND, firstName, lastName, sdt) VALUES ('" + rid + "','x','x','x')";
            // thêm contract cho phòng
            string query2 = "INSERT INTO contract (Room, Cmnd, Start_Day, End_Date) VALUES ('" + rid + "','"+rid+"','x','x')";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();

                con.Open();
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();


                MessageBox.Show("Room added");
            }
        }

            // tìm tất cả căn hộ
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select * from roominfo";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                RoomGridView.DataSource = dt;
            }
        }

            // tìm căn hộ theo mã
        private void btnRoomIDSearch_Click(object sender, EventArgs e)
        {
            string rid = boxRoomID.Text;
            
            DataTable dt = new DataTable();
            string query = "select * from roominfo where RoomID = '" + rid+"'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                RoomGridView.DataSource = dt;
            }
        }

            // tìm căn hộ theo loại căn hộ
        private void btnRoomTSearch_Click(object sender, EventArgs e)
        {
            string rtype = boxRoomType.SelectedItem.ToString();

            DataTable dt = new DataTable();
            string query = "select * from roominfo where RoomType = '" + rtype + "'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                RoomGridView.DataSource = dt;
            }
        }

        // clear text box
        private void button3_Click(object sender, EventArgs e)
        {
            boxRoomID.Text = "";
            boxRoomType.Text = "";
            boxRoomStatus.Clear();
        }

            // tự điền thông tin room
        private void RoomGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RoomGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                IDKey = RoomGridView.Rows[e.RowIndex].Cells[0].Value.ToString();


            DataTable dt = new DataTable();

            DataTable dt1 = new DataTable();

            string query = "select * from roominfo where RoomID = '" + IDKey + "'";

            string query1 = "select roomscardsvalid.*, guest_hold_card.CMND from roomscardsvalid, guest_hold_card where guest_hold_card.Card = roomscardsvalid.CardID AND guest_hold_card.CMND not like 'x' AND roomscardsvalid.RoomID = '" + IDKey + "' AND guest_hold_card.Status ='1'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                con.Close();

                con.Open();
                MySqlDataAdapter da1 = new MySqlDataAdapter(query1, con);

                da1.Fill(dt1);
                RoomGuestDetail.DataSource = dt1;
            }

            boxRoomID.Text = dt.Rows[0][0].ToString();
            boxRoomType.Text = dt.Rows[0][1].ToString();
            boxRoomStatus.Text = dt.Rows[0][2].ToString();
            
        }

        //Quản lý Khách thuê
        //-------------------------------------------------------------------------------------------------------------------------

        // tìm tất cả khách thuê
        private void btnSearchAllGuest_Click(object sender, EventArgs e)
        {
            

            DataTable dt = new DataTable();
            string query = "select contract.C_ID, guest.*, contract.Room, contract.Start_Day, contract.End_Date, contract.Status from guest, contract where guest.CMND = contract.Cmnd AND contract.Start_Day not like 'x'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                GuestGridView.DataSource = dt;
            }
        }

            // tìm khách theo CMND
        private void btnGuestSearch_Click(object sender, EventArgs e)
        {
            String cmnd = boxCMND.Text;
            
            DataTable dt = new DataTable();
            string query = "select contract.C_ID, guest.*, contract.Room, contract.Start_Day, contract.End_Date, contract.Status from guest, contract where guest.CMND = contract.Cmnd AND guest.CMND = '" + cmnd+"'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                GuestGridView.DataSource = dt;
            }
        }

            // tìm khách đang thuê
        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select contract.C_ID, guest.*, contract.Room, contract.Start_Day, contract.End_Date, contract.Status from guest, contract where guest.CMND = contract.Cmnd AND contract.Start_Day not like 'x' AND contract.Status ='1'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                GuestGridView.DataSource = dt;
            }
        }

            // tìm khách đã trả phòng
        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select contract.C_ID, guest.*, contract.Room, contract.Start_Day, contract.End_Date, contract.Status from guest, contract where guest.CMND = contract.Cmnd AND contract.Start_Day not like 'x' AND contract.Status ='0'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                GuestGridView.DataSource = dt;
            }
        }

        // khách trả phòng
        private void button4_Click(object sender, EventArgs e)
        {
            String cmnd = boxCMND.Text;
            String rid = boxGuestsRoom.Text;

            DataTable dt = new DataTable();
                // kết thúc hợp đồng
            string query = "update contract set Status = '0' where Cmnd = '"+cmnd+"' AND Status ='1'";
                // cập nhật lại thông tin thẻ
            string query1 = "update guest_hold_card set Status = '0' where CMND = '" + cmnd + "' AND Status = '1'";
                // tìm thông tin khách còn lại trong phòng
            string query2 = "select roomscardsvalid.*, guest_hold_card.CMND from roomscardsvalid, guest_hold_card where guest_hold_card.Card = roomscardsvalid.CardID AND guest_hold_card.CMND not like 'x' AND roomscardsvalid.RoomID = '" + rid + "' AND guest_hold_card.Status = '1'";
                // cập nhật thông tin phòng trống nếu thỏa điều kiện
            string query3 = "update roominfo set RoomStatus = '0' where RoomID = '"+ rid +"'";


            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();

                con.Open();
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                con.Close();

                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query2, con);

                da.Fill(dt);
                //GuestGridView.DataSource = dt;
                con.Close();

                if (dt.Rows.Count <1)
                {
                    con.Open();
                    MySqlCommand cmd3 = new MySqlCommand(query3, con);
                    MySqlDataReader reader3 = cmd3.ExecuteReader();
                }

                MessageBox.Show("Checkout finish");
            }
        }


        // xóa text box
        private void btnClearGuest_Click(object sender, EventArgs e)
        {
            boxCMND.Clear();
            boxFirstName.Clear();
            boxLastName.Clear();
            boxGuestsRoom.Clear();
            boxGuestPhone.Clear();
            boxGuestIN.Clear();
            boxGuestOut.Clear();
        }


        private void GuestGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GuestGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                IDKey = GuestGridView.Rows[e.RowIndex].Cells[0].Value.ToString();


            DataTable dt = new DataTable();

            string query = "select contract.C_ID, guest.*, contract.Room, contract.Start_Day, contract.End_Date, contract.Status from guest, contract where guest.CMND = contract.Cmnd AND contract.C_ID = '" + IDKey + "' ";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                //CardGridView.DataSource = dt;
            }

            boxCMND.Text = dt.Rows[0][1].ToString();
            boxFirstName.Text = dt.Rows[0][2].ToString();
            boxLastName.Text = dt.Rows[0][3].ToString();
            boxGuestsRoom.Text = dt.Rows[0][5].ToString();
            boxGuestPhone.Text = dt.Rows[0][4].ToString();
            boxGuestIN.Text = dt.Rows[0][6].ToString();
            boxGuestOut.Text = dt.Rows[0][7].ToString();
        }


        //Kiểm tra log
        //-------------------------------------------------------------------------------------------------------------------------

        // lấy tất cả lịch trình xe ra vào
        private void btnBikeSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select * from carinout order by Time DESC";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                BikeDoorGridView.DataSource = dt;
            }
        }

        // lấy danh sách ra vào của thẻ cid
        private void button10_Click(object sender, EventArgs e)
        {
            String cid = textBox1.Text;

            DataTable dt = new DataTable();
            string query = "select * from carinout where ID = '"+ cid +"'order by Time DESC";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                BikeDoorGridView.DataSource = dt;
            }
        }

        // test xe vào/ra
        private void btnAddtest_Click(object sender, EventArgs e)
        {
            String cid = textBox1.Text;


            DataTable dt = new DataTable();
            string query = "insert into carinout (ID, Type) values ('" + cid + "','IN')";

            string query1 = "insert into carinout (ID, Type) values ('" + cid + "','OUT')";

            string query2 = "select * from card where ID = '"+ cid +"'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query2, con);

                da.Fill(dt);
                con.Close();

                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("This Card is not in memory");
                }
                else if(checkBox1.Checked)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    MessageBox.Show("Get IN");
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query1, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    MessageBox.Show("Get OUT");
                }

            }
        }

        // khách vào phòng
        private void button8_Click(object sender, EventArgs e)
        {
            String cid = textBox7.Text;
            String rid;

            DataTable dt = new DataTable();
            //string query = "insert into roomin (ID, Type) values ('" + cid + "','" + rid + "')";

            string query1 = "select * from roomscardsvalid where CardID = '" + cid + "' ";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query1, con);

                da.Fill(dt);
                con.Close();

                
                //MessageBox.Show(rid);
                
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Thẻ không hợp lệ");
                }
                else
                {
                    rid = dt.Rows[0][0].ToString();

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into roomin (ID, Room) values ('" + cid + "','" + rid + "')", con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    MessageBox.Show("Guest IN");
                }
                

            }
        }

        // lấy danh sách log room in
        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select * from roomin order by Time DESC";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                RoomLogGridView.DataSource = dt;
            }
        }

        // lấy danh sách log vào theo phòng
        private void btnDoorSearch_Click(object sender, EventArgs e)
        {
            String rid = textBox8.Text;

            DataTable dt = new DataTable();
            string query = "select * from roomin where Room = '" + rid + "'order by Time DESC";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.Fill(dt);
                
                RoomLogGridView.DataSource = dt;
            }
        }


        //Thêm Khách
        //-------------------------------------------------------------------------------------------------------------------------

        // thêm khách
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            string cmnd = textBox2.Text;
            string fname = textBox3.Text;
            string lname = textBox4.Text;
            string rid = textBox5.Text;
            string phone = textBox6.Text;
            string cid = boxCardGiveGuest.Text;
            DateTime timein = dateTimePickerIn.Value;
            DateTime timeout = dateTimePickerOut.Value;

            DataTable dt = new DataTable();
            // Q&A
            string queryx = "select * from guest where CMND = " + cmnd + "";
            // thêm thông tin khách vào bảng guest
            string query = "INSERT INTO guest (CMND, firstname, lastname, sdt) VALUES ('"+cmnd+"','"+fname+"','"+lname+"','"+phone+"')";
            // thêm thông tin vào contract
            string query1 = "INSERT INTO contract ( Room, Cmnd, Start_Day, End_Date) VALUES ('" + rid + "','" + cmnd + "','" + timein.ToString() + "','" + timeout.ToString() + "')";
            // thêm thông tin người giữ thẻ
            string query2 = "insert into guest_hold_card (Card, CMND) values ('" + cid + "','" + cmnd + "')";
            // insert into guest_hold_card (Card, CMND, Status) values ('"+cid+"','"+CMND+"')
            // UPDATE guest_hold_card SET CMND = '"+cmnd+"' where Card = '"+cid+"'
            // cập nhật căn hộ đã có người
            string query3 = "UPDATE roominfo SET RoomStatus = '1' where RoomID = '" + rid + "'";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(queryx, con);

                da.Fill(dt);
                
                if (dt.Rows.Count < 1)
                {
                    //MessageBox.Show("This card is not belong to anyroom");
                    //boxCardGiveGuest.Clear();
                    //return;
                    //con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    con.Close();

                    con.Open();
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    con.Close();

                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    con.Close();

                    con.Open();
                    MySqlCommand cmd3 = new MySqlCommand(query3, con);
                    MySqlDataReader reader3 = cmd3.ExecuteReader();

                    MessageBox.Show("Add guest success!");
                }
                else
                {
                    //con.Open();
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    con.Close();

                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    con.Close();

                    con.Open();
                    MySqlCommand cmd3 = new MySqlCommand(query3, con);
                    MySqlDataReader reader3 = cmd3.ExecuteReader();

                    MessageBox.Show("Add guest success!");
                }


                
            }

        }

            // kiểm tra thẻ thuộc phòng nào
        private void boxCardGiveGuest_KeyDown(object sender, KeyEventArgs e)
        {
            String cid = boxCardGiveGuest.Text;

            DataTable dt = new DataTable();
            string query = "select * from roomscardsvalid where CardID = " + cid + "";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            if ( e.KeyCode == Keys.Enter)
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                    da.Fill(dt);
                    //BikeDoorGridView.DataSource = dt;
                    if ( (dt.Rows.Count < 1) || (dt.Rows[0][0].Equals("un_use")) )
                    {
                        MessageBox.Show("This card is not belong to anyroom");
                        boxCardGiveGuest.Clear();
                    }
                    else
                    {
                        textBox5.Text = dt.Rows[0][0].ToString();

                    }

                }
            }
            
        }
            // kiểm tra cmnd này từng vào ở hay chưa
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            String cmnd = textBox2.Text;

            DataTable dt = new DataTable();
            string query = "select * from guest where CMND = " + cmnd + "";

            string constr = "server=localhost; Database = qlch; Uid = root; Pwd = ; Charset = utf8";

            if (e.KeyCode == Keys.Enter)
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                    da.Fill(dt);
                    //BikeDoorGridView.DataSource = dt;
                    if (dt.Rows.Count < 1)
                    {
                        //MessageBox.Show("This card is not belong to anyroom");
                        //boxCardGiveGuest.Clear();
                        return;
                    }
                    else
                    {
                        textBox3.Text = dt.Rows[0][1].ToString();
                        textBox4.Text = dt.Rows[0][2].ToString();
                        textBox6.Text = dt.Rows[0][3].ToString();
                    }

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime timein = dateTimePickerIn.Value;
            DateTime timeout = dateTimePickerOut.Value;

            MessageBox.Show(timein.ToString());
        }

        private void btnCancelAddG_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            boxCardGiveGuest.Clear();
        }

        
    }
}
