using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodeDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeTypeId = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodeDescription_CodeType_CodeTypeId",
                        column: x => x.CodeTypeId,
                        principalTable: "CodeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CodeDescription_Module_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CodeType",
                columns: new[] { "Id", "Color", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "#fb6fed", "Error in operation or user input invalid.", "Error" },
                    { 2, "#f9fba2", "Warning in operation or user input has issue.", "Warning" },
                    { 3, "#c4c4c4", "Operation Status and info.", "Status" }
                });

            migrationBuilder.InsertData(
                table: "Module",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "General code for all system wide", "System" },
                    { 2, "UserProfile  service  ", "UserProfile" }
                });

            migrationBuilder.InsertData(
                table: "CodeDescription",
                columns: new[] { "Id", "Code", "CodeTypeId", "Description", "Message", "ModuleId" },
                values: new object[,]
                {
                    { 1000, "Error-System-1000", 1, "the field required to be entered", "RequiredField", 1 },
                    { 1015, "Status-System-1015", 3, "the operation is saved on system", "Saved", 1 },
                    { 1014, "Status-System-1014", 3, "the operation is uncompleted review errors", "Failed", 1 },
                    { 1013, "Status-System-1013", 3, "the operation is completed like reset password or verified email done", "Success", 1 },
                    { 1012, "Warning-System-1012", 2, "", "EmailVerifitionLinkShouldBeResent", 1 },
                    { 1011, "Warning-System-1011", 2, "", "PasswordStrong", 1 },
                    { 1010, "Warning-System-1010", 2, "", "PasswordMeduim", 1 },
                    { 1016, "Status-System-1016", 3, "the operation is unsaved on system review errors", "Unsaved", 1 },
                    { 1009, "Warning-System-1009", 2, "", "PasswordWeak", 1 },
                    { 1008, "Error-System-1008", 1, "miss use of values or some logic is incorrect", "InvaildField", 1 },
                    { 1007, "Error-System-1007", 1, "The link used before", "UsedLink", 1 },
                    { 1006, "Error-System-1006", 1, "the link of activation email link or password reset link in expired", "ExpiredLink", 1 },
                    { 1005, "Error-System-1005", 1, "the value not found to use like any  forgery key   or validation code", "NotExist", 1 },
                    { 1002, "Error-System-1002", 1, "Already used value like used email   ", "AlreadyExist", 1 },
                    { 1001, "Error-System-1001", 1, "authentication needed before use ", "Unauthorized", 1 },
                    { 1017, "Error-System-1017", 1, "the user email not verified and can't continue the process", "UserUnverfiedEmail", 1 },
                    { 1004, "Error-UserProfile-1004", 1, "the user trail ended and some action can't be activated", "UserTrialEnded", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodeDescription_CodeTypeId",
                table: "CodeDescription",
                column: "CodeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeDescription_ModuleId",
                table: "CodeDescription",
                column: "ModuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodeDescription");

            migrationBuilder.DropTable(
                name: "CodeType");

            migrationBuilder.DropTable(
                name: "Module");
        }
    }
}
