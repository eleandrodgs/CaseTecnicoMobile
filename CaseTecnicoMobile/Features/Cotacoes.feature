Funcionalidade: Cotacoes


Cenário:Validar tela de cotações
	Dado que quero visualizar as cotações
	Quando acesso a tela de cotações
	Então visualizo as cotações

Cenário: Validar campo de busca de cotação
	Dado que quero visualizar as cotações
	Quando busco por uma cotação valida
	E apago a cotação inserida
	Então os valores do campo de busca são apagados

Cenário: Buscar por cotação inválida
	Dado que quero visualizar as cotações
	Quando busco por uma cotação inválida
	Então obtenho a mensagem de erro



