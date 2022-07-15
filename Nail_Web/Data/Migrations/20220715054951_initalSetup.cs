using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nail_Web.Data.Migrations
{
    public partial class initalSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                           name: "ProductType",
                           columns: table => new
                           {
                               Tpe_Id = table.Column<int>(type: "int", nullable: false),
                               Tpe_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                               Tpe_ParrentTypeId = table.Column<int>(type: "int", nullable: true),
                           },
                           constraints: table =>
                           {
                               table.PrimaryKey("PK_Tpe", x => x.Tpe_Id);
                               table.ForeignKey(
                                   name: "FK_Tpe_Tpe_TypeId",
                                   column: x => x.Tpe_ParrentTypeId,
                                   principalTable: "ProductType",
                                   principalColumn: "Tpe_Id");
                           });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Prd_Id = table.Column<int>(type: "int", nullable: false),
                    Prd_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prd_AvaUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prd_ImportedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prd_Quantity = table.Column<int>(type: "int", nullable: true),
                    Prd_Size = table.Column<double>(type: "decimal", nullable: true),
                    Prd_TypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prd", x => x.Prd_Id);
                    table.ForeignKey(
                        name: "FK_Tpe_Prd_TypeId",
                        column: x => x.Prd_TypeId,
                        principalTable: "ProductType",
                        principalColumn: "Tpe_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    Clr_PrdId = table.Column<int>(type: "int", nullable: false),
                    Clr_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clr_PicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clr_UnitPrice = table.Column<int>(type: "int", nullable: true),
                    Clr_PercentUp = table.Column<double>(type: "decimal", nullable: true),
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Prd_Clr_PrdId",
                        column: x => x.Clr_PrdId,
                        principalTable: "Product",
                        principalColumn: "Prd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
               name: "MyUser",
               columns: table => new
               {
                   Usr_Id = table.Column<int>(type: "int", nullable: false),
                   Usr_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Usr_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Usr_IsAdmin = table.Column<Boolean>(type: "bit", nullable: true),
                   Usr_UserName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                   Usr_Password = table.Column<string>(type: "char(10)", nullable: true),
                   Usr_PhoneNum = table.Column<string>(type: "char(10)", nullable: true),
                   Usr_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Usr_Gender = table.Column<string>(type: "nvarchar(10)", nullable: true),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Urs", x => x.Usr_Id);
               });

            migrationBuilder.CreateTable(
              name: "Address",
              columns: table => new
              {
                  Ads_Id = table.Column<int>(type: "int", nullable: false),
                  Ads_Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                  Ads_Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  Ads_UrsId = table.Column<int>(type: "int", nullable: true),
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Ads", x => x.Ads_Id);
                  table.ForeignKey(
                      name: "FK_Usr_Ads_UsrId",
                      column: x => x.Ads_UrsId,
                      principalTable: "MyUser",
                      principalColumn: "Usr_Id",
                      onDelete: ReferentialAction.Cascade);
              });

            migrationBuilder.CreateTable(
               name: "Feedback",
               columns: table => new
               {
                   Fdb_Id = table.Column<int>(type: "int", nullable: false),
                   Fdb_UsrId = table.Column<int>(type: "int", nullable: true),
                   Fdb_PrdId = table.Column<int>(type: "int", nullable: true),
                   Fdb_Rating = table.Column<int>(type: "int", nullable: true),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Fdb", x => x.Fdb_Id);
                   table.ForeignKey(
                       name: "FK_Prd_Fdb_PrdId",
                       column: x => x.Fdb_PrdId,
                       principalTable: "Product",
                       principalColumn: "Prd_Id",
                       onDelete: ReferentialAction.Cascade);
                   table.ForeignKey(
                       name: "FK_Usr_Fdb_UsrId",
                       column: x => x.Fdb_UsrId,
                       principalTable: "MyUser",
                       principalColumn: "Usr_Id",
                       onDelete: ReferentialAction.Cascade);
               });

            migrationBuilder.CreateTable(
              name: "Cart",
              columns: table => new
              {
                  Crt_UsrId = table.Column<int>(type: "int", nullable: false),
                  Crt_PrdId = table.Column<int>(type: "int", nullable: true),
                  Crt_Quantity = table.Column<int>(type: "int", nullable: true),
                  Crt_UnitPrice = table.Column<int>(type: "int", nullable: true),
                  Crt_PercentUp = table.Column<double>(type: "decimal", nullable: true),
                  Crt_Total = table.Column<int>(type: "int", nullable: true),
              },
              constraints: table =>
              {
                  table.ForeignKey(
                      name: "FK_Prd_Crt_PrdId",
                      column: x => x.Crt_PrdId,
                      principalTable: "Product",
                      principalColumn: "Prd_Id",
                      onDelete: ReferentialAction.Cascade);
                  table.ForeignKey(
                      name: "FK_Usr_Crt_UsrId",
                      column: x => x.Crt_UsrId,
                      principalTable: "MyUser",
                      principalColumn: "Usr_Id",
                      onDelete: ReferentialAction.Cascade);
              });

            migrationBuilder.CreateTable(
               name: "PaymentMethod",
               columns: table => new
               {
                   Mtd_Id = table.Column<int>(type: "int", nullable: false),
                   Mtd_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Mtd_IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Mtd_PaymentLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Mtd", x => x.Mtd_Id);
               });

            migrationBuilder.CreateTable(
               name: "Discount",
               columns: table => new
               {
                   Dsc_Id = table.Column<int>(type: "int", nullable: false),
                   Dsc_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Dsc_MinBillVal = table.Column<int>(type: "int", nullable: true),
                   Dsc_MaxDiscount = table.Column<int>(type: "int", nullable: true),
                   Dsc_PercentDiscount = table.Column<double>(type: "decimal", nullable: true),
                   Dsc_ApplicedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                   Dsc_EndedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Dsc", x => x.Dsc_Id);
               });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Bll_Id = table.Column<int>(type: "int", nullable: false),
                    Bll_UsrId = table.Column<int>(type: "int", nullable: true),
                    Bll_AdsId = table.Column<int>(type: "int", nullable: true),
                    Bll_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bll_ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bll_TempTotal = table.Column<int>(type: "int", nullable: true),
                    Bll_DscId = table.Column<int>(type: "int", nullable: true),
                    Bll_Discount = table.Column<int>(type: "int", nullable: true),
                    Bll_ShippingFee = table.Column<int>(type: "int", nullable: true),
                    Bll_FinalTotal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bll", x => x.Bll_Id);
                    table.ForeignKey(
                        name: "FK_Usr_Bll_UserId",
                        column: x => x.Bll_UsrId,
                        principalTable: "MyUser",
                        principalColumn: "Usr_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                       name: "FK_Ads_Bll_AddressId",
                       column: x => x.Bll_AdsId,
                       principalTable: "Address",
                       principalColumn: "Ads_Id");
                    table.ForeignKey(
                       name: "FK_Dsc_Bll_DiscountId",
                       column: x => x.Bll_Discount,
                       principalTable: "Discount",
                       principalColumn: "Dsc_Id",
                       onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
             name: "BillDetail",
             columns: table => new
             {
                 Dtl_BllId = table.Column<int>(type: "int", nullable: false),
                 Dtl_PrdId = table.Column<int>(type: "int", nullable: true),
                 Dtl_Quantity = table.Column<int>(type: "nvarchar(max)", nullable: true),
                 Dtl_UnitPrice = table.Column<DateTime>(type: "datetime2", nullable: true),
                 Dtl_PercentUp = table.Column<DateTime>(type: "datetime2", nullable: true),
                 Dtl_Total = table.Column<DateTime>(type: "datetime2", nullable: true),
             },
             constraints: table =>
             {
                 table.ForeignKey(
                     name: "FK_Bll_Dtl_BllId",
                     column: x => x.Dtl_BllId,
                     principalTable: "Bill",
                     principalColumn: "Bll_Id",
                     onDelete: ReferentialAction.Cascade);
                 table.ForeignKey(
                     name: "FK_Prd_Dtl_PrdId",
                     column: x => x.Dtl_PrdId,
                     principalTable: "Product",
                     principalColumn: "Prd_Id",
                     onDelete: ReferentialAction.Cascade);
             });

            migrationBuilder.CreateIndex(
                name: "ProductIndex",
                table: "Product",
                column: "Prd_Id");

            migrationBuilder.CreateIndex(
                name: "ProductTypeIndex",
                table: "ProductType",
                column: "Tpe_Id");

            migrationBuilder.CreateIndex(
                name: "FeedbackIndex",
                table: "Feedback",
                column: "Fdb_Id");

            migrationBuilder.CreateIndex(
                name: "UserIndex",
                table: "MyUser",
                column: "Usr_Id");

            migrationBuilder.CreateIndex(
                name: "AddressIndex",
                table: "Address",
                column: "Ads_Id");

            migrationBuilder.CreateIndex(
                name: "PaymentMethodIndex",
                table: "PaymentMethod",
                column: "Mtd_Id");

            migrationBuilder.CreateIndex(
                name: "BillIndex",
                table: "Bill",
                column: "Bll_Id");

            migrationBuilder.CreateIndex(
                name: "DiscountIndex",
                table: "Discount",
                column: "Dsc_Id");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "MyUser");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "BillDetail");
        }
    }
}
