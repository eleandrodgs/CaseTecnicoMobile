Funcionalidade: Cotacoes


Cenário:Validar tela de cotações
	Dado que quero visualizar as cotações
	Quando acesso a tela de cotações
	Então visualizo a tela de cotações

Cenário: Validar campo de busca de cotação
	Dado que quero visualizar as cotações
	Quando busco pela cotação IBOV
	E apago a cotação inserida
	Então os valores do campo de busca são apagados

Cenário: Buscar por cotação inválida
	Dado que quero visualizar as cotações
	Quando busco pela cotação ABCD
	Então obtenho a mensagem de erro



