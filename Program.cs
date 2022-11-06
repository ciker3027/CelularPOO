using CELULARPOO.Models;

Smartphone nokia = new Nokia("876345120", "N454",111111111,64);
Smartphone iphone = new Iphone("895673214","7pro",44444444,64);

nokia.Ligar();
nokia.InstalarAplicativo("Cobrinha");
nokia.MostrarNumero();
nokia.Numero = "11111111";
nokia.MostrarNumero();

iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();