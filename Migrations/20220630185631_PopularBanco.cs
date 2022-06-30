using Microsoft.EntityFrameworkCore.Migrations;

namespace ReceitasMvc.Migrations
{
    public partial class PopularBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Status) Values('Sobremesas', 1)");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Status) Values('Lanches', 1)");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Status) Values('Carnes', 1)");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Status) Values('Cafés da Manhã', 1)");


            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Leite Condensado', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Manteiga', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Chocolate em pó', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Polvilho Doce', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Queijo Parmesão ralado', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Creme de Leite', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Fraldinha', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Mostarda', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Azeite', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Mel', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Suco de Limão', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Sal', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Ajinomoto', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Louro', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Banana', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Ovo', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Canela', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Chocolate Branco', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Oreo', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Nozes', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Frutas Secas', 1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome,Status) Values('Tâmaras Secas sem caroço', 1)");


            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('Lata', 1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('Colher de sopa', 1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('Copo Americano', 1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('Caixa', 1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('Quilo', 1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('Folha', 1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('Unidade', 1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('A gosto', 1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('Gramas', 1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome,Status) Values('Xícara', 1)");

            migrationBuilder.Sql("INSERT INTO Receitas(Foto, Nome, CategoriaId, ModoDePreparo, TempoDePreparo, Porcao, Status) Values('https://static.clubedaanamariabraga.com.br/wp-content/uploads/2016/11/brigadeiro-1024x576.jpg','Brigadeiro', 1,'Em uma panela funda, acrescente o leite condensado, a manteiga e o chocolate em pó. Cozinhe em fogo médio e mexa até que o brigadeiro comece a desgrudar da panela. Deixe esfriar e faça pequenas bolas com a mão.', 25, 30, 1)");
            migrationBuilder.Sql("INSERT INTO Receitas(Foto, Nome, CategoriaId, ModoDePreparo, TempoDePreparo, Porcao, Status) Values('https://th.bing.com/th/id/OIP.Dcbifgvo3cIXsL_jQ-5CTAHaE8?w=295&h=197&c=7&r=0&o=5&pid=1.7','Pão de Queijo', 2, 'Aqueça o forno a 200°C. Misture todos os ingredientes em uma tigela, até se transformar em uma massa homogênea no ponto de enrolar. Se o creme de leite utilizado for muito ralo, talvez você precise colocar um pouco mais de polvilho. Se utilizar creme de leite de lata, retire o soro e use apenas 200 g. Molde as bolinhas e coloque-as em uma assadeira untada com óleo. Leve ao forno por aproximadamente 25 minutos, até dourar levemente.', 35, 25, 1)");
            migrationBuilder.Sql("INSERT INTO Receitas(Foto, Nome, CategoriaId, ModoDePreparo, TempoDePreparo, Porcao, Status) Values('https://cdn.panelinha.com.br/receita/1564176118912-fraldinha-assada-cerveja.jpg', 'Fraldinha Assada', 3, 'Misturar todos os temperos em um recipiente uma hora antes de temperar a carne. Furar bem a fraldinha com uma faquinha fina ou garfo, temperar e deixar marinando por pelo menos umas duas horas, sempre virando a carne para pegar melhor o tempero. Assar em forno ou churrasqueira, por uma hora envolvido em papel alumínio. Depois retire o papel alumínio e deixe assar até sua preferência.', 90, 6, 1)");
            migrationBuilder.Sql("INSERT INTO Receitas(Foto, Nome, CategoriaId, ModoDePreparo, TempoDePreparo, Porcao, Status) Values('https://www.guiadasemana.com.br/contentFiles/image/2018/09/FEA/galeria/48283_w840h525_1537208367shutterstock-311041604.jpg', 'Panqueca de Banana', 4, 'Bata o ovo e amasse a banana. Junte a banana ao ovo em uma vasilha e mexa até dar liga. Adicione a canela. Acenda o fogo em temperatura média e adicione o óleo em uma frigideira grande. Com uma concha coloque a massa na frigideira formando círculos e frite dos dois lados. Mel a gosto para a cobertura.', 10, 2, 1)");
            migrationBuilder.Sql("INSERT INTO Receitas(Foto, Nome, CategoriaId, ModoDePreparo, TempoDePreparo, Porcao, Status) Values('https://www.receitasagora.com.br/wp-content/uploads/2021/03/receita-de-cookies-de-biscoito-oreo.jpg', 'Cookie de Oreo', 2, 'Forre uma forma de 20 × 20 com papel manteiga. Coloque o chocolate em banho-maria em fogo baixo e mexa constantemente, até que o chocolate esteja completamente derretido. Transfira o chocolate para uma tigela à prova de calor e esfrie por 5 minutos. Adicione as Oreos picadas e misture bem. Despeje a mistura na tigela e use uma espátula para alisar o topo. Pique os Oreos restantes e polvilhe por cima. Leve à geladeira por cerca de 10 minutos até que o chocolate endureça. Desenforme e sirva em cortes quadrados.', 30, 20, 1)");
            migrationBuilder.Sql("INSERT INTO Receitas(Foto, Nome, CategoriaId, ModoDePreparo, TempoDePreparo, Porcao, Status) Values('https://www.guiadasemana.com.br/contentFiles/image/2018/09/FEA/galeria/48283_w840h525_1537208452shutterstock-681736762.jpg','Barra de Cereal', 2, 'Coloque os ingredientes em um processador e bata até que os ingredientes formem uma massa. Isso deve acontecer depois de 2 minutos. Coloque uma parte da massa em um pedaço de filme plástico, embrulhe e leve à geladeira por pelo menos uma hora ou durante a noite. Retire a massa da geladeira e corte em pequenos quadrados e guarde na geladeira para conservar.', 120, 12, 1)");

            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 1, 2, 2, 2)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 1, 4, 2, 3)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 2, 1, 3, 4)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 2, 1, 3, 5)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 2, 1, 4, 6)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 3, 1, 5, 7)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 3, 3, 2, 8)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 3, 2, 2, 9)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 3, 1, 2, 10)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 3, 1, 3, 11)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 3, 1, 2, 12)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 3, 1, 2, 13)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 3, 1, 6, 14)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 4, 1, 7, 15)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 4, 1, 7, 16)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 4, 1, 8, 17)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 4, 1, 8, 10)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 5, 300, 9, 18)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 5, 15, 7, 19)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 6, 1, 10, 20)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 6, 1, 10, 21)");
            migrationBuilder.Sql("INSERT INTO InsumoReceitas(ReceitaId, Quantidade, MedidaId, IngredienteId) Values( 6, 1, 10, 22)");

            migrationBuilder.Sql("INSERT INTO aspnetusers(Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount) Values('9a9e4b5e-bcb9-4852-aab8-6a22bc968bce', 'admin@gft.com', 'ADMIN@GFT.COM', 'admin@gft.com', 'ADMIN@GFT.COM', 0, 'AQAAAAEAACcQAAAAEMNIyqZONBLqhfNJ2SD0e3tIoQZkLQT1O9aDg/xq17lIhb9XxxjYAcRkTOCjCq9Hyw==', 'L6RZDYGJICUAUEO5PGTXDFNSYXXUPSLQ', '9745b008-5de0-4b38-9510-44d3d256a48a', 0, 0, 1, 0 )");
            migrationBuilder.Sql("INSERT INTO aspnetusers(Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount) Values('1ff656b1-548f-4b29-8541-275286c7eab9', 'usuario@gft.com', 'USUARIO@GFT.COM', 'usuario@gft.com', 'USUARIO@GFT.COM', 0, 'AQAAAAEAACcQAAAAEH+LjgXi1Gp11O/e+cyQdnzo7KZsSMCFAeOPjOmUlTe7FNs0gTM168NWwsC36WPgNQ==', 'B2PBD3ZLE2WCQCM3BCCGPLXVBQMYED27', 'eecbdda5-ef72-445a-979b-dc0555274033', 0, 0, 1, 0)");



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
            migrationBuilder.Sql("DELETE FROM Ingredientes");
            migrationBuilder.Sql("DELETE FROM Medidas");
            migrationBuilder.Sql("DELETE FROM Receitas");
            migrationBuilder.Sql("DELETE FROM InsumoReceitas");
            migrationBuilder.Sql("DELETE FROM aspnetusers");


        }
    }
}
