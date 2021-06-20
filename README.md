# QLCH_IOT
Dự án cntt2, quản lý căn hộ cho thuê bằng IOT

Tải và cài đặt Arduino
https://www.arduino.cc/en/software


Các sản phẩm nộp cho dự án bao gồm:
- 1 website : deploy lên 1 web host để các khách hàng có nhu cầu thuê căn hộ có thể xem thông tin và liên lạc với chủ hộ qua sdt hoặc email
website này chỉ có mục đích để khách hàng xem và liên lạc, không có chức năng đặt hẹn phòng qua website, khách sẽ email hoặc gọi cho chủ căn hộ theo thông tin liên lạc
Đánh giá tiến trình: đã xây dựng web nhưng chưa deploy

- 1 windowform app : để chủ nhà có thể thực hiện các thao tác quản lý thẻ, căn hộ, khách
Đánh giá tiến trình: xây dựng xong giao diện cơ bản, chưa thiết lập event vì đang chỉnh sửa database

- 1 script sử dụng cho "ID reader A" : được đặt ở vị trí quầy tiếp tân hoặc phòng làm việc, gần thiết bị PC/Laptop chứa database, "ID reader A" có chức năng đọc và viết thông tin XYZ(mã căn hộ) vào thẻ RFID
Đánh giá tiến trình: đã hoàn thiện việc kết nối reader vào giao diện app, có thể đọc ID và đưa lên giao diện app ; đã có code viết thông tin XYZ vào thẻ nhưng chưa sử dụng được trên app, chỉ có thể làm bằng arduino monitor

- 1 script sử dụng cho "ID reader B" : được đặt ở vị trí cửa phòng căn hộ, không kết nối trực tiếp với PC/Laptop, "ID reader B" có chức năng đọc thông tin XYZ được lưu trong thẻ, sau đó so sánh với mã căn hộ được lưu trong code của từng reader theo căn hộ; sau khi xác nhận thẻ ID hợp lệ reader sẽ gửi thông tin ID của thẻ và mã căn hộ lên server thông qua wifi; khi server nhận được ID thẻ và mã căn hộ, sẽ lưu lại vào database cùng với thời gian thực tế
Đánh giá tiến trình: đã có code đọc thông tin lưu trong thẻ ; chưa thực hiện được việc đẩy data lên server qua wifi

- 1 script sử dụng cho "ID reader C" : được đặt ở vị trí ra vào bãi xe, không kết nối trực tiếp với PC/Laptop, "ID reader C" có chức năng kiểm tra ID của thẻ; nếu thẻ hợp lệ và được quét bởi máy C1 thì sẽ log lại thời gian vào, nếu thẻ hợp lệ và được quét bởi máy C2 thì sẽ được log lại là thời gian ra
Đánh giá tiến trình: đã có code đọc thông tin lưu trong thẻ ; chưa thực hiện được việc đẩy data lên server qua wifi

