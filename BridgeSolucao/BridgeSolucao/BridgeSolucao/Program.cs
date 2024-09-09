using BridgeSolucao.Canal;
using BridgeSolucao.Mensagem;

CanalDeEnvio canalEmail = new Email();

Mensagem msgAdmin = new MensagemAdmin(canalEmail);
msgAdmin.setAssunto("Primeira Mensagem");
msgAdmin.setMensagem("Olá Usuário!");
msgAdmin.enviarMensagem();

Mensagem msgUsuario = new MensagemUsuario(canalEmail);
msgAdmin.setAssunto("Primeira Mensagem");
msgAdmin.setMensagem("Olá Usuário!");
msgAdmin.enviarMensagem();

CanalDeEnvio canalSms = new Sms();

Mensagem msgAdmin2 = new MensagemAdmin(canalSms);
msgAdmin.setAssunto("Primeira Mensagem");
msgAdmin.setMensagem("Olá Usuário!");
msgAdmin.enviarMensagem();

Mensagem msgUsuario2 = new MensagemAdmin(canalSms);
msgAdmin.setAssunto("Primeira Mensagem");
msgAdmin.setMensagem("Olá Usuário!");
msgAdmin.enviarMensagem();