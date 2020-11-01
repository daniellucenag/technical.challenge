# technical.challenge

  Implementação teste técnico Localiza
  
# executar

  Existem 3 formas de executar o projeto:
  * 1 - Via console application executando o projeto console
  * 2 - Via API executando o projeto api, o projeto de API ja abre no swagger que descreve a API implementada.
  * 3 - Via docker (É necessário posssuir o docker instalado):
	* 3.1 - Acessar a pasta do projeto via linha de comando
	* 3.2 - Executar o comando "docker build -t divisores-api-image -f Dockerfile-api ." que irá executar os comandos do Dockerfile-api na raiz
	* 3.3 - Executar o comando "docker run -d -p 8080:80 --name divisores-api-image divisores-api-image"
	* 3.4 - Acessar: http://localhost:8080/swagger/ 

# descriçao do desafio

• Um cliente precisa de um sistema que seja capaz de decompor um número em todos os
seus divisores, enumerando também aqueles que forem primos. Obs.: Não é permitido o
uso de bibliotecas prontas, se houver, que façam a decomposição. 
• Dado um número de entrada, o programa deve calcular todos os divisores que
compõem o número. 
• Dado um número de entrada, o programa deve calcular todos os
divisores primos que compõem o número. 

 
• Já temos nossa funcionalidade principal. Contudo, você acaba de descobrir que essa
funcionalidade vai ser usada em outros sistemas e, por isso, é necessário que seja
disponibilizada um serviço que forneça as informações. Fique atento a: 
• Performance 
• Escalabilidade 
• Disponibilidade 
• Resiliência 
• Robustez
