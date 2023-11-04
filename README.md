# Teste Grupo SKA Vitor Nicacio

Instruções sobre a implantação e testes:

1 - Passo
-- ./appsettings.json --

O parâmetro DataBase recebe as informações de autenticação com o banco de dados.
Altere as credenciais de autenticação para a sua conexão com o banco de dados SQL Server.

  "ConnectionStrings": {
    "DataBase": "Server=GALAXYBOOKS\\SQLEXPRESS;Database=BLOCO_NOTAS_VITOR_SKA;User Id=vn;Password=123456;TrustServerCertificate=true"
  },


2 - Passo
-- Configuração Projeto -- 

Acesse o Menu Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciar do Pacotes

Utilize o prompt para executar as linhas de comando abaixo

Add-Migration [SKAVitor] -Context DataBaseContext

O nome [SKAVitor] pode ser alterado para um ALIAS de sua preferência para representar a migração das alterações que devems ser aplicadas ao banco.

Após isso execute a linha de comando para aplicar a migração efetivamente.

Update-DataBase -Context DataBaseContext

Feito isso serão criados o banco de dados e a tabela representando o modelo apontado.