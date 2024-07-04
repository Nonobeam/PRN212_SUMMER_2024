using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueConstraintToEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Service__3214EC0782A7EF1C", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Time_slot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__time_slo__3214EC07FE2606AB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "varchar(225)", unicode: false, maxLength: 225, nullable: false),
                    available = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User__3214EC070099FC43", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admin__1788CC4C48100467", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__Admin__UserId__5165187F",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__1788CC4CB2808141", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__Customer__UserId__3D5E1FD2",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Manager__1788CC4C040F6614", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__Manager__UserId__403A8C7D",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clinic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    available = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Clinic__3214EC07DE02B697", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Clinic__ManagerI__4316F928",
                        column: x => x.ManagerId,
                        principalTable: "Manager",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Dentist",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClinicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dentist__1788CC4C03311E62", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__Dentist__ClinicI__48CFD27E",
                        column: x => x.ClinicId,
                        principalTable: "Clinic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Dentist__UserId__47DBAE45",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Time_slotId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    DentistId = table.Column<int>(type: "int", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    clinicid = table.Column<int>(type: "int", nullable: true),
                    available = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Appointm__3214EC07F123F71B", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Appointme__Custo__4BAC3F29",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK__Appointme__Denti__4CA06362",
                        column: x => x.DentistId,
                        principalTable: "Dentist",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK__Appointme__Servi__4D94879B",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Appointme__Time___4E88ABD4",
                        column: x => x.Time_slotId,
                        principalTable: "Time_slot",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "fk_clinic",
                        column: x => x.clinicid,
                        principalTable: "Clinic",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_clinicid",
                table: "Appointment",
                column: "clinicid");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CustomerId",
                table: "Appointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DentistId",
                table: "Appointment",
                column: "DentistId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ServiceId",
                table: "Appointment",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Time_slotId",
                table: "Appointment",
                column: "Time_slotId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinic_ManagerId",
                table: "Clinic",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dentist_ClinicId",
                table: "Dentist",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_User_email",
                table: "User",
                column: "email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Dentist");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Time_slot");

            migrationBuilder.DropTable(
                name: "Clinic");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
