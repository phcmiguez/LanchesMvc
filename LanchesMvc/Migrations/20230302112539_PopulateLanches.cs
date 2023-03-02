using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMvc.Migrations
{
    /// <inheritdoc />
    public partial class PopulateLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches" +
            "(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque)" +
            "VALUES(1,'Big Burger', 'Hamburguer estilo McDonalds','Um Hambúrger Americano bem elaborado e saboroso',39.90,'lanche01.png','lanche01.png',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches" +
            "(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque)" +
            "VALUES(1,'Hot Dog', 'Melhor Cachorro quente da cidade','Acompanha batata palha e milho verde',9.90,'lanche02.png','lanche02.png',1,1)");

            migrationBuilder.Sql("INSERT INTO Lanches" +
            "(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque)" +
            "VALUES(1,'Pitbull','X-Tudo', '2 Carnes de Hamburger e muito mais', 59.90,'lanche03.png','lanche03.png',1,1)");

            migrationBuilder.Sql("INSERT INTO Lanches" +
            "(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque)" +
            "VALUES(2,'Frango da Malásia', 'Hamburguer de frango','Um Hambúrger Feito com Frango da Malásia',49.90,'lanche04.png','lanche04.png',0,0)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
