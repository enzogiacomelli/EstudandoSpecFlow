 Funcionalidade: Login


Cenário: Login com sucesso
Dado Que eu esteja na página de login
Quando Eu insiro as credenciais do usuário e clico em login
Então O login deve ser feito com sucesso

Cenário: Login sem sucesso
Dado Que eu esteja na página de login
Quando Eu insiro as credenciais do usuário inválido e clico em login
Então O login deve falhar