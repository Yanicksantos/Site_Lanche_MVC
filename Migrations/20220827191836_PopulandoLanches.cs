using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_loja.Migrations
{
    public partial class PopulandoLanches : Migration
    {
         protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(categoriaId, Nome, DescricaoCurta, Preco, IsPreferido, IsEstoque)"+
            "VALUES(2, 'Baurú', 'Delicioso e suculento Baurú', 7.99, 0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(categoriaId, Nome, DescricaoCurta, Preco, IsPreferido, IsEstoque)"+
            "VALUES(1, 'Enroladinho', 'Melhor enroladinho da cidade', 5.50, 1,1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
