# Teste Grupo SKA Vitor Nicacio

Instru��es sobre a implanta��o e testes:

1 - Passo
-- ./appsettings.json --

O par�metro DataBase recebe as informa��es de autentica��o com o banco de dados.
Altere as credenciais de autentica��o para a sua conex�o com o banco de dados SQL Server.

  "ConnectionStrings": {
    "DataBase": "Server=GALAXYBOOKS\\SQLEXPRESS;Database=BLOCO_NOTAS_VITOR_SKA;User Id=vn;Password=123456;TrustServerCertificate=true"
  },


2 - Passo
-- Configura��o Projeto -- 

Acesse o Menu Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciar do Pacotes

Utilize o prompt para executar as linhas de comando abaixo

Add-Migration [SKAVitor] -Context DataBaseContext

O nome [SKAVitor] pode ser alterado para um ALIAS de sua prefer�ncia para representar a migra��o das altera��es que devems ser aplicadas ao banco.

Ap�s isso execute a linha de comando para aplicar a migra��o efetivamente.

Update-DataBase -Context DataBaseContext

Feito isso ser�o criados o banco de dados e a tabela representando o modelo apontado.