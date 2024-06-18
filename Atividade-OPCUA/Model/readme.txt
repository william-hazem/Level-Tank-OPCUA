Instruções para gerar os arquivos do modelo para o SDK da OPC Foundation

* Execute o UA Model Compiler no prompt de comando

-d2: Especifique o caminho do arquivo que contêm o modelo de informação .xml
-o : Caminho de saída do gerador

.\Opc.Ua.ModelCompiler.exe -d2 <caminho.xml> -cg <caminho.csv> -o <caminho_saida> -console -version v104

