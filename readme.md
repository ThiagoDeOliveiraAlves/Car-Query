<h1>Car Query</h1>

<p>Sistema para consulta, gerenciamento e exibição de carros, com funcionalidades para usuários e administradores</p>

<h2>Índice</h2>
<ul>
  <li><a href="#sobre-o-sistema">Sobre o sistema</a></li>
  <li><a href="#tecnologias-utilizadas">Tecnologias utilizadas</a></li>
  <li><a href="#modelo-de-dados">Modelo de dados</a></li>
  <li><a href="#funcionalidades">Funcionalidades (com gifs)</a></li>
</ul>

<h2 id="sobre-o-sistema">Sobre o sistema</h2>

<p>Car Query é uma aplicação web que desenvolvi para desenvolver minhas habilidades em C# e ASP.NET Core.</p>
<p>
  O sistema permite consultar informações dos carros cadastrados no sistema, tais como potência, ano de modelo e de fabricação, aspiração, transmissão, tração e outras informações, 
  bem como visualizar imagens e um vídeo sobre o carro.
</p>
<p>
  O Car Query também disponibiliza uma pesquisa filtrada, onde o usuário pode pesquisar por marca, potênica, ano e preço, sendo possível especificar um intervalo nos campos numéricos, 
como potência mínima e potência máxima.
</p>
<p>
  Os veículos podem ser cadastrados e gerenciados através de contas de "Admin" e de "SuperAdmin". O usuário SuperAdmin é o usuário de maior hierarquia do sistema, além de poder gerenciar
  carros e os carrosséis exibidos na página inicial, ele também gerencia os usuários. Somente o SuperAdmin pode cadastrar novos administradores, ou seja perfil do tipo "Admin", perfil este que 
  autoriza o gerenciamento dos carros e carrosséis.
</p>

<h2 id="tecnologias-utilizadas">Tecnologias utilizadas</h2>

* [![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-5a01ba?style=for-the-badge&logo=dotnet&logoColor=white)](https://learn.microsoft.com/pt-br/aspnet/core/)
* [![C#](https://img.shields.io/badge/C%23-500177?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/pt-br/dotnet/csharp/)
* [![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)](https://developer.mozilla.org/pt-BR/docs/Web/JavaScript)
* [![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)](https://developer.mozilla.org/pt-BR/docs/Web/HTML)
* [![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)](https://developer.mozilla.org/pt-BR/docs/Web/CSS)
* [![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)](https://getbootstrap.com)


<h2 id="modelo-de-dados">Modelo de dados</h2>

```mermaid
erDiagram
direction LR

AspNetUsers{
    string Id "Not Null"
    string UserName "Nullable"
    string NormalizedUserName "Nullable"
    string Email "Nullable"
    string NormalizedEmail "Nullable"
    bool EmailConfirmed "Not Null"
    string PasswordHash "Nullable"
    string SecurityStamp "Nullable"
    string ConcurrencyStamp "Nullable"
    string PhoneNumber "Nullable"
    bool PhoneNumberConfirmed "Not Null"
    bool TwoFactorEnabled "Not Null"
    datetime LockoutEnd "Nullable"
    bool LockoutEnabled "Not Null"
    int AccessFailedCount "Not Null"
}

AspNetUserRoles{
    string UserId "Not Null"
    string RoleId "Not Null"
}

AspNetUserLogins{
    string LoginProvider "Not Null"
    string ProviderKey "Not Null"
    string ProviderDisplayName "Nullable"
    string UserId "Not Null"
}

AspNetUserClaims{
    int Id "Not Null"
    string UserId "Not Null"
    string ClaimType "Nullable"
    string ClaimValue "Nullable"
}

AspNetRoles{
    string Id "Not Null"
    string Name "Nullable"
    string NormalizedName "Nullable"
    string ConcurrencyStamp "Nullable"
}

AspNetRoleClaims{
   int Id "Not Null"
string RoleId "Not Null"
string ClaimType "Nullable"
string ClaimValue "Nullable"
}

AspNetUserTokens{
    string UserId "Not Null"
    string LoginProvider "Not Null"
    string Name	"Not Null"
    string Value "Nullable"
}

Car{
    int CarId "Not Null"
    string Brand "Not Null"
    string Model "Not Null"
    string ManufacturingYear "Not Null"
    int ModelYear "Not Null"
    short Power "Not Null"
    string Drivetrain "Not Null"
    string EnginePosition "Not Null"
    string TransmissionType "Not Null"
    short TopSpeed "Not Null"
    short Doors "Not Null"
    decimal Price "Not Null"
    string ShortDescription "Not Null"
    string FullDescription "Not Null"
    string VideoLink "Not Null"
    string Aspiration "Not Null"
    string BodyStyle "Not Null"
    string CylinderConfiguration "Not Null"
    int Cylinders "Not Null"
    string Displacement "Not Null"
    string FuelType "Not Null"
    int Valves "Not Null"
}

Carousel{
    int CarouselId "Not Null"
    string Title "Not Null"
    short Position "Not Null"
    bool IsVisible "Not Null"
}

CarouselSlide{
    int CarouselSlideId	"Not Null"
    int CarouselId "Not Null"
    int CarId "Not Null"
    int ImageId	"Not Null"
}

Image{
    int ImageId	"Not Null"
    string ImgPath	"Not Null"
    int CarId "Not Null"
}

AspNetUsers ||--o{ AspNetUserClaims : has
AspNetUsers ||--o{ AspNetUserLogins : has
AspNetUsers ||--o{ AspNetUserTokens : has
AspNetUsers ||--o{ AspNetUserRoles : has
AspNetRoles ||--o{ AspNetUserRoles : has
AspNetRoles ||--o{ AspNetRoleClaims : has

Car ||--|{ Image : has
Carousel ||--o{ CarouselSlide : has
CarouselSlide }|--|| Car : has
CarouselSlide }|--|{ Image : has
```
<!--
    Relações no Mermaid:
    ||--|| = um para um
    ||--o{  = um para zero-ou-muitos
   
    || = exatamente um (chave estrangeira faz parte da chave primária da tabela dependente. Dependência forte)
    }o = zero ou um
    }| = exatamente um (chave estrangeira é apenas um campo comum, não faz parte de PK. Dependência fraca)
    o{ = zero ou muitos
    |{ = um ou muitos
--->

<hr/>
<h2 id="funcionalidades">Funcionalidades</h2>
<h3>Usuário comum</h3>

* <h4>Responsividade</h4>
<div style="margin-left: 40px">
  <p>O layout do sistema se adapta para dispositivos mobile e desktop</p>
  <img src="./readme-assets/1-Responsividade-edited.gif" width="600">
</div>

* <h4>Visualizar carrosséis</h4>
<div style="margin-left: 40px">
  <p>O usuário pode visualizar e interagir com os carrosséis apresentados na tela inicial</p>
  <img src="./readme-assets/2-Show-carousels.gif" width="600">
</div>

* <h4>Pesquisar veículos</h4>
<div style="margin-left: 40px">
  <p>O usuário pode pesquisar veículos por marca ou modelo</p>
  <img src="./readme-assets/3-Search-by-brand-model.gif" width="600">
</div>

* <h4>Visualizar informações dos veículos</h4>
<div style="margin-left: 40px">
  <p>O usuário pode visualizar informações do veículo selecionado</p>
  <img src="./readme-assets/4-Car-details.gif" width="600">
</div>

* <h4>Pesquisa filtrada de veículos</h4>
<div style="margin-left: 40px">
  <p>O usuário pode realizar pesquisas com filtros, podendo especificar a marca, bem como o intervalo de ano do modelo, potência e preço.</p>
  <img src="./readme-assets/5-Filter-search-edited.gif" width="600">
</div>

* <h4>Enviar feedback</h4>
<div style="margin-left: 40px">
  <p>O usuário pode enviar feedbacks para a equipe gestora do sistema. Os feedbacks podem ser conferidos pela equipe gestora no @@@@@@@@@@@@</p>
  <img src="./readme-assets/6-Feedback.gif" width="600">
</div>

<h3>Administrador (Admin)</h3>

* <h4>Login</h4>
<div style="margin-left: 40px">
  <p>Os administradores podem realizar login para acessar a página de administração do site</p>
  <img src="./readme-assets/7-login.gif" width="600">
</div>

* <h4>Adicionar carro</h4>
<div style="margin-left: 40px">
  <p>Os administradores podem adicionar novos carros no sistema, preenchendo suas infromações técnicas e adicionando imagens e um vídeo do youtube</p>
  <img src="./readme-assets/8- Add-car-gif-highR.gif" width="600">
</div>

* <h4>Listar carros</h4>
<div style="margin-left: 40px">
  <p>O sistema lista todos os carros cadastrados no sistema, disponibilizando um campo para pesquisa e as operações de gerência de carros</p>
  <img src="./readme-assets/9-List-cars-admin.gif" width="600">
</div>

* <h4>Editar carro</h4>
<div style="margin-left: 40px">
  <p>Os administradores podem atualizar ou corrigir os dados dos veículos</p>
  <img src="./readme-assets/10-Edit-car-edited.gif" width="600">
</div>

* <h4>Deletar carro</h4>
<div style="margin-left: 40px">
  <p>Os administradores podem deletar carros do sistema</p>
  <img src="./readme-assets/11-Delete-car.gif" width="600">
</div>

* <h4>Carrosséis</h4>
<div style="margin-left: 40px">
  <p>Para permitir que o site ficasse mais dinâmico, criei um sistema de carrosséis para que os administradores possam alterar as apresentações da tela inicial.</p>
  <p>Um carrossel é um conjunto de slides contendo um carro cada, que são exibidos na tela inicial do sistema. Cada    carrossel possui um título e uma lista de veículos. 
  Um carrossel pode estar habilitado ou desabilitado. Caso esteja habilitado, ele é exibido na página inicial, do contrário ele continua no sistema mas não é exibido.
  Cada carrossel possui uma posição que indica a ordem que serão exibidas na tela inicial.</p>
</div>

* <h4>Adicionar carrossel</h4>
<div style="margin-left: 40px">
  <p>
    O sistema permite a criação carrosséis que são exibidos na tela inicial, permitindo que os administradores adicionem um título, selecionem os carros e suas imagens para serem exibidos no carrossel.
    Cada carro é exibido em um slide diferente
  </p>
  <img src="./readme-assets/12-Add-carousel-edited.gif" width="600">
</div>

* <h4>Listar carrosséis</h4>
<div style="margin-left: 40px">
  <p>O sistema lista todos os carrosséis cadastrados no sistema, disponibilizando um campo para busca dos carrosséis (por título) e disponibilizando as operações de gerência de carrosséis</p>
  <img src="./readme-assets/13-List-carousels.gif" width="600">
</div>

* <h4>Editar carrossel</h4>
<div style="margin-left: 40px">
  <p>Os administradores podem atualizar ou corrigir dados dos carrosséis, podendo alterar os veículos apresentados no carrossel, seu título, se está habilitado ou desabilitado e alterar a posição do carrossel.</p>
  <img src="./readme-assets/14-Edit-carousel-edited.gif" width="600">
</div>

* <h4>Deletar carrossel</h4>
<div style="margin-left: 40px">
  <p>Os administradores podem deletar carrosséis</p>
  <img src="./readme-assets/15-Delete-carousel.gif" width="600">
</div>

<h3>Super administrador (SuperAdmin)</h3>

<p>Além de ter acesso a todas as operações do Admin, possui as seguintes permissões</p>

* <h4>Registrar novo administrador</h4>
<div style="margin-left: 40px">
  <p>O super administrador pode registrar novos administradores</p>
  <img src="./readme-assets/16-Add-user-edited.gif" width="600">
</div>
* <h4>Listar administradores</h4>
<div style="margin-left: 40px">
  <p>O super administrador pode visualizar todos os administradores cadastrados no sistema</p>
  <img src="./readme-assets/17-List-users.gif" width="600">
</div>

* <h4>Editar administrador</h4>
<div style="margin-left: 40px">
  <p>O super administrador pode atualizar as informações das contas "Admin"</p>
  <img src="./readme-assets/18-Edit-user-edited.gif" width="600">
</div>

* <h4>Deletar administrador</h4>
<div style="margin-left: 40px">
  <p>O super administrador pode deletar contas de administradores</p>
  <img src="./readme-assets/19-Delete-user.gif" width="600">

</div>
