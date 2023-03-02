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
            "VALUES(1,'Big Burger', 'Hamburguer estilo McDonalds','Um Hambúrger Americano bem elaborado e saboroso',39.90,'hamb01.jpg','hamb01thumb.jpg',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches" +
            "(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque)" +
            "VALUES(1,'Hot Dog', 'Melhor Cachorro quente da cidade','Acompanha batata palha e milho verde',9.90,'hot01.jpg','hot01thumb.jpg',1,1)");

            migrationBuilder.Sql("INSERT INTO Lanches" +
            "(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque)" +
            "VALUES(1,'Pitbull','X-Tudo', '2 Carnes de Hamburger e muito mais', 59.90,'xtudo01.jpg','xtudothumb.jpg',1,1)");

            migrationBuilder.Sql("INSERT INTO Lanches" +
            "(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque)" +
            "VALUES(2,'Frango da Malásia', 'Hamburguer de frango','Um Hambúrger Feito com Frango da Malásia',49.90,'hamb04.jpg','hamb04thumb.jpg',0,0)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
