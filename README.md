Projeto feito a partir de: 
https://www.macoratti.net/20/10/aspnc_impclean1.htm
https://macoratti.net/21/03/efc_idesig1.htm

##Usando a migration

Ajuste o package manager para user o Shop.Infra.Data como default project e defina o projeto MVC como startup project, tamb�m � necess�rio declara��o <PrivateAssets>all</PrivateAssets> da refer�ncia ao pacote Microsoft.EntityFrameworkCore.Design no arquivo de projeto.

Rode pelo package manager:
add-migration inicial
update-database