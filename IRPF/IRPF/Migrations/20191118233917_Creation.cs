using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IRPF.Migrations
{
    public partial class Creation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    NumberDep = table.Column<int>(nullable: false),
                    Prev = table.Column<double>(nullable: false),
                    TotalIncome = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Declarations",
                columns: table => new
                {
                    DeclarationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Incomme = table.Column<double>(nullable: false),
                    Dependents = table.Column<int>(nullable: false),
                    SocialSecurity = table.Column<double>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Declarations", x => x.DeclarationId);
                    table.ForeignKey(
                        name: "FK_Declarations_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deductions",
                columns: table => new
                {
                    DeductionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<double>(nullable: false),
                    DeclarationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deductions", x => x.DeductionID);
                    table.ForeignKey(
                        name: "FK_Deductions_Declarations_DeclarationID",
                        column: x => x.DeclarationID,
                        principalTable: "Declarations",
                        principalColumn: "DeclarationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Declarations_UserID",
                table: "Declarations",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deductions_DeclarationID",
                table: "Deductions",
                column: "DeclarationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deductions");

            migrationBuilder.DropTable(
                name: "Declarations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
