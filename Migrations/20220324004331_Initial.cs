using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AptId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<string>(nullable: false),
                    Day = table.Column<string>(nullable: false),
                    Booked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AptId);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    AptId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Booking_Appointment_AptId",
                        column: x => x.AptId,
                        principalTable: "Appointment",
                        principalColumn: "AptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 1, false, "Monday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 61, false, "Friday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 60, false, "Friday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 59, false, "Friday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 58, false, "Friday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 57, false, "Friday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 56, false, "Thursday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 55, false, "Thursday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 54, false, "Thursday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 53, false, "Thursday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 52, false, "Thursday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 51, false, "Thursday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 50, false, "Thursday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 49, false, "Thursday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 48, false, "Thursday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 47, false, "Thursday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 46, false, "Thursday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 45, false, "Thursday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 62, false, "Friday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 44, false, "Thursday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 63, false, "Friday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 65, false, "Friday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 82, false, "Saturday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 81, false, "Saturday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 80, false, "Saturday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 79, false, "Saturday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 78, false, "Saturday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 77, false, "Saturday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 76, false, "Saturday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 75, false, "Saturday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 74, false, "Saturday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 73, false, "Saturday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 72, false, "Saturday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 71, false, "Saturday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 70, false, "Friday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 69, false, "Friday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 68, false, "Friday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 67, false, "Friday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 66, false, "Friday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 64, false, "Friday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 43, false, "Thursday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 42, false, "Wednesday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 41, false, "Wednesday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 18, false, "Tuesday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 17, false, "Tuesday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 16, false, "Tuesday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 15, false, "Tuesday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 14, false, "Monday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 13, false, "Monday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 12, false, "Monday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 11, false, "Monday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 10, false, "Monday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 9, false, "Monday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 8, false, "Monday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 7, false, "Monday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 6, false, "Monday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 5, false, "Monday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 4, false, "Monday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 3, false, "Monday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 2, false, "Monday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 19, false, "Tuesday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 20, false, "Tuesday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 21, false, "Tuesday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 22, false, "Tuesday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 40, false, "Wednesday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 39, false, "Wednesday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 38, false, "Wednesday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 37, false, "Wednesday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 36, false, "Wednesday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 35, false, "Wednesday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 34, false, "Wednesday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 33, false, "Wednesday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 83, false, "Saturday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 32, false, "Wednesday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 30, false, "Wednesday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 29, false, "Wednesday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 28, false, "Tuesday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 27, false, "Tuesday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 26, false, "Tuesday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 25, false, "Tuesday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 24, false, "Tuesday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 23, false, "Tuesday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 31, false, "Wednesday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AptId", "Booked", "Day", "Time" },
                values: new object[] { 84, false, "Saturday", "8:00 PM" });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_AptId",
                table: "Booking",
                column: "AptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Appointment");
        }
    }
}
