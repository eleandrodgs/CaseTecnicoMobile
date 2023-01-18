

# Case Técnico API  
Projeto de teste Mobile Android desenvolvido como parte do processo seletivo no Itáu, que realiza testes no app Itaú Corretora.

## Tecnologias utilizadas 
AppiumWebDriver 4.4.0

SpecFlow.NUnit 3.9.40

NUnit 3.13.2

AVD Manager Android

Appium Server

## Estrutura do projeto
`App`: Caminho com o .apk do aplativo a ser testado.

`Drivers`: Classe responsável por configurar as capabilites do dispositivo androind no AVD Manager Android.

`Features:` Diretório que contém os testes em Specflow.

`Helpers:` Classes que dão suporte à execução dos testes.

`Hooks:` Estrutura base para a execução com Specflow.

`Pages:`Implementação dos elementos de cada tela do app.

`Steps:`Implementação dos steps de cada cenário das fetures.

## Execução do Testes

1. Primeiramente, realize o clone do projeto.

2. Para executar o projeto é necessário ter instalado o AndroidStudio e a dependência AVD Manager Android. Para configurar o ambiente de execução, siga os passos descritos nesse link: https://eliasnogueira.github.io/appium-workshop/

3. Configure um dispositivo no AVD Manager Android com as características descritas no arquivo `Driver/AppiumDriver.cs`

4. Para realizar a conexão com o dispositivo cadastrado no AVD Manager Android, vamos utilizar o AppiumServer GUI, disponível pra download do link: (https://github.com/appium/appium-desktop/releases/tag/v1.22.3-4).

5. Execute o Appium Server GUI com as seguintes informações: 
	5.1 `Host: 127.0.0.1`
	5.2 `Port: 4723`

### Execução local utilizando o Visual Studio e AppiumServer

1. Execute o dispositivo configurado no AVD Manager Android
2. Abra o projeto no VisualStudio 2022.
3. Ative a janela Text Explorer, no menu Tools > Test Explorer.
3. Clique com botão direito em 'Run Tests'.


 






