using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SrDashboard_SR.Migrations
{
    public partial class in1t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "account_types",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    description = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "computer_types",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_computer_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "environment_types",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_environment_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "offices",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_offices", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "servers",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false),
                    Servername = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Ipadress = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    ServiceName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    ServiceStatus = table.Column<bool>(nullable: true),
                    DateTime = table.Column<byte[]>(rowVersion: true, nullable: true),
                    ServerFQDN = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "system_types",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    description = table.Column<string>(unicode: false, nullable: true),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true),
                    deleted_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    email_verified_at = table.Column<DateTime>(nullable: true),
                    password = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    remember_token = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Workload",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    Servername = table.Column<string>(unicode: false, nullable: false),
                    Ipadress = table.Column<string>(unicode: false, nullable: false),
                    ServiceName = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workload", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "consultants",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    phone = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    non_disclosure_agreement = table.Column<short>(nullable: true, defaultValueSql: "((0))"),
                    non_disclosure_agreement_date = table.Column<DateTime>(type: "date", nullable: true),
                    system_type_id = table.Column<long>(nullable: true),
                    office_id = table.Column<long>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true),
                    deleted_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultants", x => x.id);
                    table.ForeignKey(
                        name: "fk_consultants_consultant_offices",
                        column: x => x.office_id,
                        principalTable: "offices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_consultants_system_types",
                        column: x => x.system_type_id,
                        principalTable: "system_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "consultant_accounts",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    consultant_id = table.Column<long>(nullable: true),
                    account_type_id = table.Column<long>(nullable: false),
                    environment_type_id = table.Column<long>(nullable: false),
                    expire_at = table.Column<DateTime>(type: "date", nullable: true),
                    description = table.Column<string>(unicode: false, nullable: true),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true),
                    deleted_at = table.Column<DateTime>(nullable: true),
                    password_expire_at = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultant_accounts", x => x.id);
                    table.ForeignKey(
                        name: "fk_consultant_accounts_account_types",
                        column: x => x.account_type_id,
                        principalTable: "account_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_consultant_accounts_consultants",
                        column: x => x.consultant_id,
                        principalTable: "consultants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_consultant_accounts_environment_types",
                        column: x => x.environment_type_id,
                        principalTable: "environment_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "consultant_computers",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    consultant_id = table.Column<long>(nullable: false),
                    computer_type_id = table.Column<long>(nullable: false),
                    environment_type_id = table.Column<long>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true),
                    deleted_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultant_computers", x => x.id);
                    table.ForeignKey(
                        name: "consultant_computers_ibfk_1",
                        column: x => x.computer_type_id,
                        principalTable: "computer_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "consultant_computers_ibfk_2",
                        column: x => x.consultant_id,
                        principalTable: "consultants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "consultant_computers_ibfk_3",
                        column: x => x.environment_type_id,
                        principalTable: "environment_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fk_consultant_accounts_account_types",
                table: "consultant_accounts",
                column: "account_type_id");

            migrationBuilder.CreateIndex(
                name: "fk_consultant_accounts_consultants",
                table: "consultant_accounts",
                column: "consultant_id");

            migrationBuilder.CreateIndex(
                name: "fk_consultant_accounts_environment_types",
                table: "consultant_accounts",
                column: "environment_type_id");

            migrationBuilder.CreateIndex(
                name: "computer_type_id",
                table: "consultant_computers",
                column: "computer_type_id");

            migrationBuilder.CreateIndex(
                name: "consultant_id",
                table: "consultant_computers",
                column: "consultant_id");

            migrationBuilder.CreateIndex(
                name: "environment_type_id",
                table: "consultant_computers",
                column: "environment_type_id");

            migrationBuilder.CreateIndex(
                name: "fk_consultants_consultant_offices",
                table: "consultants",
                column: "office_id");

            migrationBuilder.CreateIndex(
                name: "fk_consultants_system_types",
                table: "consultants",
                column: "system_type_id");

            migrationBuilder.CreateIndex(
                name: "users_email_unique",
                table: "users",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "consultant_accounts");

            migrationBuilder.DropTable(
                name: "consultant_computers");

            migrationBuilder.DropTable(
                name: "servers");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Workload");

            migrationBuilder.DropTable(
                name: "account_types");

            migrationBuilder.DropTable(
                name: "computer_types");

            migrationBuilder.DropTable(
                name: "consultants");

            migrationBuilder.DropTable(
                name: "environment_types");

            migrationBuilder.DropTable(
                name: "offices");

            migrationBuilder.DropTable(
                name: "system_types");
        }
    }
}
