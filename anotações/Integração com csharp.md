> Podemos utilizar o C# para manipular dados do arduino

## Bibliotecas:
* *"using System.IO.Ports;"*
	* Para podermos manipular os dados de entrada (Input) e saída (Output)

## Códigos
> No Visual Studio 2015:
```C#
private void button2_Click(object sender, EventArgs e)
        {
            // Botão de desligar
            // instanciando a porta COM4 para ser utilizada
            SerialPort port = new SerialPort("COM4", 9600);
            // Abrindo a porta para ser utilizada
            port.Open();
            // chamando a função de escrever "1"
            port.Write("1");
            // fechando a porta e encerrando o uso
            port.Close();

        }
```

> No arduíno:
```C
int ledPin = 13;
int n = 0;

void setup() {
  // put your setup code here, to run once:
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available() > 0){
     n = Serial.read();
  }
  if(n=='1'){
   digitalWrite(ledPin, HIGH);
  } else if(n=='0'){
   digitalWrite(ledPin, LOW);
  }
}
```
