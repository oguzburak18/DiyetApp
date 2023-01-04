using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetApp.Contexts.Migrations
{
    public partial class migo4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CerezBaklagilGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CerezBaklagilGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CerezBaklagilGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CerezBaklagilPorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CerezBaklagilPorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CerezBaklagilPorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DigerGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigerGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DigerGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DigerPorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigerPorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DigerPorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EtGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EtGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EtPorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtPorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EtPorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FastFoodGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastFoodGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FastFoodGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FastFoodPorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastFoodPorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FastFoodPorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IcecekMler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ml = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcecekMler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IcecekMler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IcecekPorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcecekPorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IcecekPorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeyveGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeyveGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeyveGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeyvePorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeyvePorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeyvePorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SebzeGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SebzeGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SebzeGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SebzePorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SebzePorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SebzePorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SutGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SutGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SutGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SutPorsiyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SutPorsiyons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SutPorsiyons_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TahilGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahilGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TahilGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TahilPorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahilPorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TahilPorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YagGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YagGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YagGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YagPorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YagPorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YagPorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekGramlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekGramlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YemekGramlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekPorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekPorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YemekPorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CerezBaklagilGramlar_KategoriId",
                table: "CerezBaklagilGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_CerezBaklagilPorsiyonlar_KategoriId",
                table: "CerezBaklagilPorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_DigerGramlar_KategoriId",
                table: "DigerGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_DigerPorsiyonlar_KategoriId",
                table: "DigerPorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_EtGramlar_KategoriId",
                table: "EtGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_EtPorsiyonlar_KategoriId",
                table: "EtPorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_FastFoodGramlar_KategoriId",
                table: "FastFoodGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_FastFoodPorsiyonlar_KategoriId",
                table: "FastFoodPorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_IcecekMler_KategoriId",
                table: "IcecekMler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_IcecekPorsiyonlar_KategoriId",
                table: "IcecekPorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_MeyveGramlar_KategoriId",
                table: "MeyveGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_MeyvePorsiyonlar_KategoriId",
                table: "MeyvePorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_SebzeGramlar_KategoriId",
                table: "SebzeGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_SebzePorsiyonlar_KategoriId",
                table: "SebzePorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_SutGramlar_KategoriId",
                table: "SutGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_SutPorsiyons_KategoriId",
                table: "SutPorsiyons",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_TahilGramlar_KategoriId",
                table: "TahilGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_TahilPorsiyonlar_KategoriId",
                table: "TahilPorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_YagGramlar_KategoriId",
                table: "YagGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_YagPorsiyonlar_KategoriId",
                table: "YagPorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekGramlar_KategoriId",
                table: "YemekGramlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekPorsiyonlar_KategoriId",
                table: "YemekPorsiyonlar",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CerezBaklagilGramlar");

            migrationBuilder.DropTable(
                name: "CerezBaklagilPorsiyonlar");

            migrationBuilder.DropTable(
                name: "DigerGramlar");

            migrationBuilder.DropTable(
                name: "DigerPorsiyonlar");

            migrationBuilder.DropTable(
                name: "EtGramlar");

            migrationBuilder.DropTable(
                name: "EtPorsiyonlar");

            migrationBuilder.DropTable(
                name: "FastFoodGramlar");

            migrationBuilder.DropTable(
                name: "FastFoodPorsiyonlar");

            migrationBuilder.DropTable(
                name: "IcecekMler");

            migrationBuilder.DropTable(
                name: "IcecekPorsiyonlar");

            migrationBuilder.DropTable(
                name: "MeyveGramlar");

            migrationBuilder.DropTable(
                name: "MeyvePorsiyonlar");

            migrationBuilder.DropTable(
                name: "SebzeGramlar");

            migrationBuilder.DropTable(
                name: "SebzePorsiyonlar");

            migrationBuilder.DropTable(
                name: "SutGramlar");

            migrationBuilder.DropTable(
                name: "SutPorsiyons");

            migrationBuilder.DropTable(
                name: "TahilGramlar");

            migrationBuilder.DropTable(
                name: "TahilPorsiyonlar");

            migrationBuilder.DropTable(
                name: "YagGramlar");

            migrationBuilder.DropTable(
                name: "YagPorsiyonlar");

            migrationBuilder.DropTable(
                name: "YemekGramlar");

            migrationBuilder.DropTable(
                name: "YemekPorsiyonlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
