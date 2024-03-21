


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Sobre esse Projeto

Projeto crud para teste de desenvolvimento Junior



### Built With

Projeto Executando com Windows forms, c#, Sql serve e entity framework

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

Clone do projeto no github

### Prerequisites

Ter instalado dotNet 7
Docker com SQL Server ou SQL Express ou usar SQL server

### Installation

Depois de instalado o SQL SERVER mudar a string de conexão para o banco correto

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=172.19.16.1; Database=dbRepository; User Id=sa; Password=#sa123456; TrustServerCertificate=True"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

Depois de configurado a conexão executar o script do banco

dbRepository.sql
