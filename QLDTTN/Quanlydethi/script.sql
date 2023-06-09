USE [THITRACNGHIEM]
GO
/****** Object:  Table [dbo].[CAUHOI]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAUHOI](
	[MACH] [nvarchar](50) NOT NULL,
	[TENCH] [nvarchar](max) NULL,
	[LOAICH] [nvarchar](50) NULL,
 CONSTRAINT [PK_CAUHOI] PRIMARY KEY CLUSTERED 
(
	[MACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DAPAN]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAPAN](
	[MACH] [nvarchar](50) NOT NULL,
	[A] [nvarchar](max) NULL,
	[B] [nvarchar](max) NULL,
	[C] [nvarchar](max) NULL,
	[D] [nvarchar](max) NULL,
	[Dapan] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KETQUA]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KETQUA](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MATHISINH] [nvarchar](50) NOT NULL,
	[NGAYTHI] [datetime] NULL,
	[SOCAUDUNG] [int] NULL,
	[SOCAUSAI] [int] NULL,
	[DIEM] [int] NULL,
 CONSTRAINT [PK_KETQUA] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THISINHX]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THISINHX](
	[MATHISINH] [nvarchar](50) NOT NULL,
	[NGAYGIANHAP] [datetime] NULL,
	[NGAYSINH] [datetime] NULL,
	[DIACHI] [nvarchar](50) NULL,
	[GMAIL] [nvarchar](50) NULL,
 CONSTRAINT [PK_THISINHX] PRIMARY KEY CLUSTERED 
(
	[MATHISINH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'', N'File chứa mã nguồn java sau khi được biên dịch có đuôi là gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0002', N'Java platform gồm mấy thành phần?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0003', N'Java Virtual Machine là gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0004', N'Java chạy trên hệ điều hành nào sau đây:', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0005', N'Ngôn ngữ lập trình Java cung cấp các tính năng nào sau đây?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0006', N'Có bao nhiêu cách viết chú thích trong Java?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0007', N'Thứ tự các từ khóa public và static khi khai bao như thế nào?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0008', N'Khi biên dịch gặp lỗi Exception in thread main java.lang.NoClassDefFoundError:myprogram. Lỗi này có nghĩa gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0009', N'Một lớp trong Java có thể có bao nhiêu lớp cha?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0010', N'Một lớp trong Java có bao nhiêu lớp con?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'0011', N'Chọn câu trả lời đúng nhất. Interface là gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'012', N'Cách Chú thích nào sau đây là sai?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'014', N'Đối tượng trong phần mềm là gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'015', N'Khai báo lớp nào dưới đây là đúng?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'016', N'Trong Java Có Mấy Loại Vòng Lặp', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'017', N'Cách đặt tên nào sau đây là sai?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'018', N'Một chương trình gồm 2 class sẽ có  bao nhiêu phương thức main?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'019', N'Để khai báo lớp Xedap1 kế thừa lớp Xedap phải làm như thế nào?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'020', N'Để sử dụng giao diện Xedap cho lớp Xedap1, ta làm thế nào?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'021', N'Có bao nhiêu loại biến trong Java?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'022', N'Trường dữ liệu là các biến dạng nào sau đây?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'023', N'Cách đặt tên nào sau đây là không chính xác?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'024', N'Có Bao nhiêu kiểu số nguyên trong java', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'026', N'Lệnh str.charat(n) có tác dụng gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'027', N': Khối lệnh sau có kết quả bao nhiêu khi thực hiện? char[] greet = new char[10]; greet = “Hello”; k = greet.length(); System.out.print(k);', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'029', N'Trong Java, kiểu char biểu diễn bộ mã code nào dưới đây?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'030', N'Giá trị mặc định của một biến kiểu char là?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'031', N'Hai câu lệnh sau ra kết quả s là bao nhiêu String greetings = “Hello”;', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'032', N'Kiểu enum là gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'033', N'Phạm vi truy cập của một đối tượng khi khai báo private là gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'034', N'Biến f nào sau đây là biến đại diện?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'035', N'Khai báo nào sau đây là khai báo biến lớp?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'036', N'Có bao nhiêu kiểu dữ liệu ký tự cơ sở trong Java?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'037', N'Trong các kiểu giá trị số thực đặc biệt dưới đây, kiểu nào là đúng?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'038', N'Phạm vi truy cập của một đối tượng khi được khai báo public là gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'039', N'Phương thức nào dùng để tìm kiếm một chuỗi trong một chuỗi khác trong class String của Java?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'040', N'Phương thức nào của class String trả về index của chuỗi ký tự con xuất hiện đầu tiên trong chuỗi ký tự char ”', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'041', N'Trong Java, kiểu dữ liệu nào là một địa chỉ của đối tượng hoặc một mảng được tạo ra trong bộ nhớ?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'042', N'Chức năng của vòng lặp while là gi?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'043', N'Lệnh result = condition ? value1 : value2 có nghĩa gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'044', N'Lệnh nào ngừng vòng lặp hiện thời và bắt đầu vòng lặp tiếp theo?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'045', N'Cách khai báo mảng nào sau đây là đúng?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'046', N'Để đảo giá trị của một biến boolean, ta dùng toán tử nào?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'047', N'Lệnh if CONDITION { Khối lệnh } có tác dụng gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'048', N'Lệnh if CONDITION {Khối lệnh 1} else {Khối lệnh 2} có tác dụng gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'049', N'Để kiểm tra 2 chuỗi có bằng nhau hay không, sử dụng phương thức nào?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'050', N'Lệnh charAt(n) có tác dụng gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'051', N'Lệnh sau in ra kết quả là bao nhiêu: double x = 10000.0 / 3.0;  System.out.print(x);', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'052', N'Chọn định dạng hiển thị khi thực hiện câu lệnh sau: System.out.printf(“%tc”, new Date());', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'053', N'Chọn định dạng hiển thị khi thực hiện câu lệnh sau: System.out.printf(“%1$s %2$tB %2$te, %2$tY”, “Due date:”, new Date());', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'054', N'Lệnh nào chỉ sử dụng trong trường hợp các vòng lặp lồng nhau?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'055', N'Hàm nào sau đây có thể được sử dụng đối với output có định dạng?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'056', N'Định nghĩa interface nào sau đây là không hợp lệ?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'057', N'Cho String str = “univerity”, lệnh nào dưới đây lấy chuỗi “univer” và gắn vào chuỗi str1?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'058', N'Cho str = “Yunlin universtiy”, lệnh str.indexOf(“uni”) trả về kết quả là gì?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'059', N'Cho str = “Yunlin universtiy”, lệnh str.indexOf(“uni”) trả về kết quả là gì?aCho str = “Yunlin university”, lệnh str.lastIndexOf(“i”, 7) trả về kết quả là bao nhiêu?', N'null')
INSERT [dbo].[CAUHOI] ([MACH], [TENCH], [LOAICH]) VALUES (N'060', N'Ưu điểm của nested class là gì?', N'null')
GO
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0003', N'Là chương trình chạy cho java', N'Tất cả các đáp án đều đúng', N'Là một thành phần của Java platform dùng để đọc mã bytecode trong file .class', N'Là chương trình biên dịch của java dùng để biên dịch file java', N'C')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0008', N'Đường dẫn chương trình sai', N'Không có hàm main', N'Không khai báo class', N'Không có từ khóa public tại mở đầu khai báo class', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0009', N'1', N'2', N'3', N'4', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0010', N'1', N'2', N'3', N'vô số', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0011', N'Là lớp chứa các phương thức rỗng có liên quan với nhau.', N'Là một kiểu tham chiếu, tương tự như class, chỉ có thể chứa hằng giá trị, khai báo phương thức và kiểu lồng', N'Là một phương thức thực hiện của lớp khác.', N'Là lớp nối giữa lớp cơ sở và lớp cha', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'032', N'Là kiểu dữ liệu gồm các trường chứa một tập hợp cố định các hằng số.', N'Là kiểu dữ liệu liệt kê các biến số', N'Là kiểu Số Nguyên', N'là Kiểu Số Thực', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'033', N'Có thể được truy cập bất kỳ vị trí nào trong chương trình.', N'Chỉ Được truy cập trong class đó', N'Có thể được truy cập từ các lớp trong cùng package và lớp con nằm trong package  khác.', N'Có thể được truy cập từ các lớp trong cùng package.', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0001', N'.class', N'.jav', N'.java', N'.exe', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0002', N'1', N'2', N'3', N'4', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0004', N'Microsoft Windows', N'Android', N'Linux', N'Tất cả các đáp Án trên', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0005', N'Thư viện tích hợp', N'Bộ công cụ giao diện người dùng', N'Giao diện lập trình ứng dụng', N'Tất cả các đáp Án trên', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0006', N'1', N'2', N'3', N'4', N'C')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0007', N'public đứng trước static', N'static đứng trước public', N'Thứ tự bất kỳ nhưng thông thường public đứng trước', N'Tất cả đều sai', N'C')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'017', N'2wword', N'*word', N'main', N'Tất cả Đều Sai', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'018', N'1', N'2', N'3', N'4', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'023', N'final', N'_final', N'dem', N'staticfinal', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'024', N'1', N'2', N'3', N'Tất cả đều sai', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'026', N'Lấy ký tự bất kỳ trong chuỗi str', N'Lấy độ dài chuỗi str', N'Lấy ký tự có số chỉ mục n trong chuỗi k', N'Không Có lệnh này', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'027', N'3', N'4', N'10', N'Lỗi Biên dịch', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'029', N'UTF-8', N'UTF-16', N'UTF-32', N'Tất Cả Đều Đúng', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'030', N'u0000', N'0x7', N'uFFFFx5', N'0', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'031', N'Hel', N'Hello', N'ello', N'H', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'0001', N'Là chương trình chạy cho java', N'Tất cả các đáp án đều đúng', N'Là một thành phần của Java platform dùng để đọc mã bytecode trong file .class', N'Là chương trình biên dịch của java dùng để biên dịch file java', N'')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'012', N'/** chú thích */', N'/* Chú thích*/', N'//chú thích', N'--chú thích--', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'014', N'Là một bó phần mềm gồm các hành vi và trạng thái có liên quan với nhau', N'Là vật thể xác định của thế giới thực', N'Là vật thể gồm hành vi và trạng thái', N'Là các đối tượng được biểu diễn trong phần mềm gồm có 2 thuộc tính trường dữ liệu và các phương thức xử lý dữ liệu', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'015', N'public class default {}', N'protected inner class engine {}', N'final class outer {}', N'Tất cả đều sai.', N'C')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'016', N'1', N'2', N'3', N'4', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'019', N'class Xedap1 extend Xedap {}', N'public classs Xedap1 extend Xedap {}', N'class Xedap1 extends Xedap {}', N'Tất Cả Đều Đúng', N'C')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'020', N'class Xedap1 implement Xedap {}', N'public class Xedap1 implement Xedap {}', N'class Xedap1 extends Xedap {}', N'class Xedap1 implements Xedap {}', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'021', N'1', N'2', N'3', N'4', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'022', N'Biến đại diện và Tham số', N'Biến đại diện và biến lớp', N'Biến đại diện và biến cục bộ', N'Biến lớp và Tham số', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'034', N'float f;', N'public static f;', N'double CA(int f)', N'Không có giá trị đúng', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'035', N'final double x;', N'private static y;', N'volatile int z;', N'Không có giá trị đúng', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'036', N'1', N'2', N'3', N'4', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'039', N'lastIndexOf()', N'substring()', N'toString()', N'Không có đáp án đúng', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'040', N'indexOf()', N'concat()', N'toString()', N'Không có đáp án đúng', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'046', N'!', N'>>', N'++', N'<<<', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'047', N'Nếu CONDITION đúng thì thực hiện Khối lệnh, nếu sai thì bỏ qua', N'Nếu CONDITION sai thì thực hiện Khối lệnh, nếu đúng thì bỏ qua', N'Tất cả đều sai.', N'Không có đáp án đúng', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'052', N'Sun Dec 02 2018', N'Sun Dec 02 17:26:19 ICT 2018', N'Sunday December 05:26:00 ICT 2018', N'lỗi khi biên dịch', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'053', N'Due date:Dec 02 2018', N'Sun Dec 02 2018', N'Due date: Dec 02, 2018', N'Dec 02, 2018', N'C')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'054', N'label', N'jump', N'array', N'Không có đáp án đúng', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'060', N'Cho phép nhóm logic các class', N'Dễ sửa, thay đổi code', N'Tăng tính đóng kín', N'Tất cả các tính chất trên', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'037', N'Dương vô cực', N'Âm vô cực', N'NaN', N'Tất cả 3 đáp án trên', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'038', N'Có thể được truy cập từ bất kỳ vị trí nào trong chương trình.', N'Có thể được truy cập từ các lớp trong cùng package.', N'Có thể được truy cập từ các lớp trong cùng package và lớp con nằm trong package khác', N'Chỉ có thể truy cập từ các phương thức khác trong class đó.', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'041', N'Kiểu primitive', N'Kiểu reference', N'Kiểu format', N'Không có đáp án đúng.', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'042', N'Kiểm tra kết quả của biểu thức boolean', N'Lặp lại khối lệnh chứng nào điều kiện là đúng', N'Tránh mâu thuẫn giữa bên trong và bên ngoài switch', N'Không có đáp án đúng', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'043', N'nếu condition là true thì result = value2, nếu condition là false thì result = value1', N'nếu condition là true thì result = value1, nếu condition là false thì result = value2', N'Nếu condition là true thì result sẽ đảo giá trị của value1 và value2', N'Không có lệnh này', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'044', N'continue', N'break', N'Return -1', N'end', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'045', N'int[] a;', N'int a[];', N'int a[] = new int[10];', N'Cả 3 cách khai báo đều đúng.', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'048', N'Nếu CONDITION đúng thì thực hiện Khối lệnh, nếu sai thì bỏ qua', N'nếu CONDITION đúng thì thực hiện Khối lệnh 1, nếu sai thì thực hiện Khối lệnh 2', N'nếu CONDITION sai thì thực hiện Khối lệnh 1, nếu đúng thì thực hiện Khối lệnh 2', N'Nếu CONDITION đúng thì thực hiện Khối lệnh 2, nếu đúng thì bỏ qua', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'049', N'string1== string2', N'string1 = string2', N'string1.equals(string2)', N'string1.equal(string2)', N'C')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'050', N'Tìm kiếm ký tự thứ n', N'Trả về ký tự thứ n-1', N'Trả về ký tự thứ n', N'Trả về ký tự có vị trí chỉ mục n', N'D')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'051', N'3333.3333333333335', N'3333.33', N'0', N'3332.0', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'055', N'print()', N'println()', N'format()', N'scanf()', N'C')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'056', N'public interface inout {}', N'protected interface inout { int i = 12;}', N'interface inout { public final int MAX_INDEX = 100;}', N'interface input { public void indl();}', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'057', N'String str1 = str.substring(0, 6);', N'String str1 = str.substring(0, 5);', N'String str1 = str.substring(6, 5);', N'String str1 = str.substring(0, 10);', N'A')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'058', N'1', N'7', N'15', N'sai', N'B')
INSERT [dbo].[DAPAN] ([MACH], [A], [B], [C], [D], [Dapan]) VALUES (N'059', N'4', N'7', N'15', N'sai', N'A')
GO
SET IDENTITY_INSERT [dbo].[KETQUA] ON 

INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (4, N'duy', CAST(N'2018-02-03T00:00:00.000' AS DateTime), 2, 3, 100)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (6, N'duy', CAST(N'2018-03-30T00:00:00.000' AS DateTime), 7, 3, 70)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (7, N'duy', CAST(N'2018-03-31T00:00:00.000' AS DateTime), 8, 12, 20)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (8, N'duy', CAST(N'2018-03-31T00:00:00.000' AS DateTime), 9, 11, 22)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (10, N'bich', CAST(N'2018-04-01T00:00:00.000' AS DateTime), 4, 16, 10)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (11, N'duy', CAST(N'2018-04-02T00:00:00.000' AS DateTime), 18, 2, 45)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (13, N'admin', CAST(N'2018-04-04T00:00:00.000' AS DateTime), 0, 20, 0)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (14, N'admin', CAST(N'2018-04-04T00:00:00.000' AS DateTime), 3, 17, 7)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (15, N'haha', CAST(N'2018-04-04T00:00:00.000' AS DateTime), 18, 2, 45)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (1013, N'tool', CAST(N'2018-04-04T00:00:00.000' AS DateTime), 6, 14, 30)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (2013, N'admin', CAST(N'2018-04-06T00:00:00.000' AS DateTime), 15, 5, 75)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (3013, N'admin', CAST(N'2018-04-16T00:00:00.000' AS DateTime), 3, 17, 15)
INSERT [dbo].[KETQUA] ([STT], [MATHISINH], [NGAYTHI], [SOCAUDUNG], [SOCAUSAI], [DIEM]) VALUES (3014, N'richard', CAST(N'2018-04-17T00:00:00.000' AS DateTime), 13, 7, 65)
SET IDENTITY_INSERT [dbo].[KETQUA] OFF
GO
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'admin', N'duydeptrai', 1)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'alex', N'a', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'barry', N'dkmaksd', 1)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'team', N'hihi', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'duy', N'234', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'1234', N'Zoom', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'LALA', N'1234', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'dell', N'123', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'tool', N'123', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'bich', N'bichh', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'Richard', N'123', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'haha', N'huhu', 0)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Role]) VALUES (N'Facebook', N'1234', 0)
GO
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'admin', CAST(N'1998-04-23T00:00:00.000' AS DateTime), CAST(N'1998-02-24T00:00:00.000' AS DateTime), N'Silicon Valley', N'admin@gmail.io')
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'bich', CAST(N'2018-04-01T00:00:00.000' AS DateTime), CAST(N'2018-12-09T00:00:00.000' AS DateTime), N'nd', N'bich')
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'dell', CAST(N'2018-04-04T00:00:00.000' AS DateTime), CAST(N'1992-04-17T00:00:00.000' AS DateTime), N'usa', N'dellio.com')
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'duy', CAST(N'1998-01-28T00:00:00.000' AS DateTime), CAST(N'2018-03-11T00:00:00.000' AS DateTime), N'hn', N'duy@io.com')
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'Facebook', CAST(N'2018-03-25T00:00:00.000' AS DateTime), CAST(N'1958-03-16T00:00:00.000' AS DateTime), N'Central City', N'Facebook@gmail.com')
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'haha', CAST(N'2018-03-24T00:00:00.000' AS DateTime), CAST(N'2018-03-05T00:00:00.000' AS DateTime), N'Hà Nội', N'haha@gmail.com')
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'Richard', CAST(N'2018-04-17T00:00:00.000' AS DateTime), CAST(N'1998-04-26T00:00:00.000' AS DateTime), N'silicon valley -canifornia', N'rich@gmai.com')
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'Team', CAST(N'2018-03-26T00:00:00.000' AS DateTime), CAST(N'1998-03-15T00:00:00.000' AS DateTime), N'hà nội', N'team123@gmail.com')
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'tool', CAST(N'2018-04-04T00:00:00.000' AS DateTime), CAST(N'2018-04-02T00:00:00.000' AS DateTime), N'hn', N'123@gmail.com')
INSERT [dbo].[THISINHX] ([MATHISINH], [NGAYGIANHAP], [NGAYSINH], [DIACHI], [GMAIL]) VALUES (N'Zoom', CAST(N'2018-03-24T00:00:00.000' AS DateTime), CAST(N'1997-08-20T00:00:00.000' AS DateTime), N'Hanoi', N'zom@gmail.com')
GO
ALTER TABLE [dbo].[KETQUA]  WITH CHECK ADD  CONSTRAINT [FK_KETQUA_THISINHX] FOREIGN KEY([MATHISINH])
REFERENCES [dbo].[THISINHX] ([MATHISINH])
GO
ALTER TABLE [dbo].[KETQUA] CHECK CONSTRAINT [FK_KETQUA_THISINHX]
GO
/****** Object:  StoredProcedure [dbo].[DELETE_CAUHOI]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_CAUHOI]
@sMACH nvarchar(50)
AS
IF NOT EXISTS(SELECT MACH FROM CAUHOI WHERE MACH=@sMACH)
BEGIN
RAISERROR('Không Thể Xóa Câu Hỏi Không Tồn Tại' ,16, 1)
RETURN
END
DELETE FROM CAUHOI WHERE MACH=@sMACH
DELETE FROM DAPAN WHERE MACH=@sMACH
GO
/****** Object:  StoredProcedure [dbo].[DELETE_THISINH]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_THISINH]
@sMATHISNH nvarchar(50)
AS
IF NOT EXISTS (SELECT MATHISINH FROM THISINHX WHERE MATHISINH=@sMATHISNH)
BEGIN
RAISERROR('Lỗi',16,1)
RETURN
END
DELETE THISINHX WHERE MATHISINH=@sMATHISNH
GO
/****** Object:  StoredProcedure [dbo].[INSERT_CH]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_CH]
@sMACH nvarchar(50),
@sTENCH nvarchar(MAX),
@sLOAICH nvarchar(50)
AS
DECLARE @ketqua nvarchar(MAX)
-- Thêm Mã Câu Hỏi, Tên CH ,LOẠI CH 
IF EXISTS (SELECT MACH FROM CAUHOI WHERE MACH=@sMACH)
BEGIN 
RAISERROR('Mã  đã tồn tại, thêm mới bị hủy bỏ' ,16, 1)
SET @ketqua='loi da ton tai'
PRINT @ketqua
RETURN
END
INSERT INTO CAUHOI VALUES(@sMACH,@sTENCH,@sLOAICH)

GO
/****** Object:  StoredProcedure [dbo].[INSERT_DAPAN]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_DAPAN]
@sMACH nvarchar(50),
@sA nvarchar(MAX),
@sB nvarchar(MAX),
@sC nvarchar(MAX),
@sD nvarchar(MAX),
@sDAPAN nvarchar(50)
AS
DECLARE @sErrMSG nvarchar(50)
IF EXISTS (SELECT MACH FROM CAUHOI WHERE MACH=@sMACH)
BEGIN 
SET @sErrMSG='loi da ton tai CH NAY'
PRINT @sErrMSG
RETURN
END
INSERT INTO DAPAN VALUES(@sMACH,@sA,@sB,@sC,@sD,@sDAPAN)
GO
/****** Object:  StoredProcedure [dbo].[INSERT_KQ]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_KQ]
@sMATHISINH nvarchar(50),
@sNGAYTHI   datetime,
@sSOCAUDUNG  int,
@sSOCAUSAI int,
@sDIEM int
AS
INSERT INTO KETQUA VALUES(@sMATHISINH,@sNGAYTHI,@sSOCAUDUNG,@sSOCAUSAI,@sDIEM)
GO
/****** Object:  StoredProcedure [dbo].[INSERT_USER]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_USER]
@sUsername nvarchar(50),
@sPassWord nvarchar(50),
@sRole bit=false,
@sMATHISINH nvarchar(50),
@sNGAYGIANHAP datetime,
@sNGAYSINH datetime,
@sDIACHI nvarchar(50),
@sGMAIL nvarchar(50)
As
BEGIN 
INSERT INTO TAIKHOAN VALUES(@sUsername,@sPassWord,@sRole)
INSERT INTO THISINHX  VALUES(@sMATHISINH,@sNGAYGIANHAP,@sNGAYSINH,@sDIACHI,@sGMAIL)
END
GO



/****** Object:  StoredProcedure [dbo].[INSERT_USER_AMIN]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_USER_ADMIN]
@sUsername nvarchar(50),
@sPassWord nvarchar(50),
@sRole bit=true
As
BEGIN 
INSERT INTO TAIKHOAN VALUES(@sUsername,@sPassWord,@sRole)
END
GO

/****** Object:  StoredProcedure [dbo].[UPDATE_CAUHOI_AND_DAPAN]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATE_CAUHOI_AND_DAPAN]
@sMACH nvarchar(50),
@sTENCH nvarchar(MAX) =null,
@sLOAICH nvarchar(50)=null,
@sA nvarchar(MAX)=null,
@sB nvarchar(MAX)=null,
@sC nvarchar(MAX)=null,
@sD nvarchar(MAX)=null,
@sDapan nvarchar(MAX)=null
AS
IF NOT EXISTS(SELECT MACH FROM CAUHOI WHERE MACH=@sMACH)
BEGIN
RAISERROR(' Câu Hỏi Không Tồn Tại' ,16, 1)
RETURN
END
IF @sTENCH IS NOT NULL
UPDATE CAUHOI SET TENCH=@sTENCH WHERE MACH=@sMACH

IF @sLOAICH IS NOT NULL
UPDATE CAUHOI SET LOAICH=@sLOAICH WHERE MACH=@sMACH

IF @sA IS NOT NULL
UPDATE DAPAN SET A=@sA WHERE MACH=@sMACH

IF @sB IS NOT NULL
UPDATE DAPAN SET B=@sB WHERE MACH=@sMACH

IF @sC IS NOT NULL
UPDATE DAPAN SET C=@sC WHERE MACH=@sMACH

IF @sD IS NOT NULL
UPDATE DAPAN SET C=@sC WHERE MACH=@sMACH

IF @sDapan IS NOT NULL
UPDATE DAPAN SET Dapan=@sDapan WHERE MACH=@sMACH
GO
/****** Object:  StoredProcedure [dbo].[Update_pass]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[Update_pass]
@sUsername nvarchar(50),
@sPassword nvarchar(50)
As
BEGIN
update TAIKHOAN SET Username =Username,Password=@sPassword,role=role Where Username = @sUsername
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_THISINNH]    Script Date: 5/14/2023 9:41:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATE_THISINNH]
@sMATHISNH nvarchar(50),
@sNGAYGIANHAP datetime=null,
@sNGAYSINH datetime=null,
@sDIACHI nvarchar(50)=null,
@sGMAIL nvarchar(50)=null

AS
IF NOT EXISTS (SELECT MATHISINH FROM THISINHX WHERE MATHISINH=@sMATHISNH)
BEGIN
RAISERROR('Lỗi',16,1)
RETURN
END
IF @sNGAYGIANHAP IS NOT NULL
UPDATE THISINHX SET NGAYGIANHAP=@sNGAYGIANHAP WHERE MATHISINH=@sMATHISNH

IF @sNGAYSINH IS NOT NULL
UPDATE THISINHX SET NGAYSINH=@sNGAYSINH WHERE MATHISINH=@sMATHISNH

IF @sDIACHI IS NOT NULL
UPDATE THISINHX SET DIACHI=@sDIACHI WHERE MATHISINH=@sMATHISNH

IF @sGMAIL IS NOT NULL
UPDATE THISINHX SET GMAIL=@sGMAIL WHERE MATHISINH=@sMATHISNH

GO
