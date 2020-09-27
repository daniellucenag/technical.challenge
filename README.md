# technical.challenge

  Implementação teste técnico Localiza 09/2020
  
# executar

  Existem 3 formas de executar o projeto:
  1 - Via console application executando o projeto console
  3 - Via API executando o projeto api, o projeto de API ja abre no swagger que descreve a API implementada.
  3 - Via docker (É necessário posssuir o docker instalado):
	3.1 - Acessar a pasta do projeto via linha de comando
	3.2 - Executar o comando "docker build -t divisores-api-image -f Dockerfile-api ." que irá executar os comandos do Dockerfile-api na raiz
	3.3 - Executar o comando "docker run -d -p 8080:80 --name divisores-api-image divisores-api-image"
	3.4 - Acessar: http://localhost:8080/swagger/ 


  
