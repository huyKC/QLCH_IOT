# QLCH_IOT
Dự án cntt2, quản lý căn hộ cho thuê bằng IOT

Tải và cài đặt Arduino
https://www.arduino.cc/en/software


Các sản phẩm nộp cho dự án bao gồm:
- 1 website : deploy lên 1 web host để các khách hàng có nhu cầu thuê căn hộ có thể xem thông tin và liên lạc với chủ hộ qua sdt hoặc email
website này chỉ có mục đích để khách hàng xem và liên lạc, không có chức năng đặt hẹn phòng qua website, khách sẽ email hoặc gọi cho chủ căn hộ theo thông tin liên lạc

  => _Đánh giá tiến trình: đã xây dựng web nhưng chưa deploy_

- 1 windowform app : để chủ nhà có thể thực hiện các thao tác quản lý thẻ, căn hộ, khách

  => _Đánh giá tiến trình: xây dựng xong giao diện cơ bản, xây dựng xong event chức năng_
  
link video demo : https://youtu.be/BgEB9Lvi3Dc

- Các sketch arduino dùng cho RFID bao gồm :
- 1 sketch cho việc đọc ID thẻ nhựa
- 1 sketch cho việc viết data cần lưu trữ cào thẻ
- 1 sketch cho việc đọc data ở cổng gửi xe ra vào
- 1 sketch cho việc đọc data ở cửa chính vào căn hộ
- chi tiết các sketch được chứa trong thư mục DỰ ÁN 2 ARDUINO CODE .note
