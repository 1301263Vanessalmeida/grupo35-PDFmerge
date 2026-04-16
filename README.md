# grupo35-PDFmerge
Aplicação desenvolvida no âmbito da unidade curricular Laboratório de Desenvolvimento de Software, com objetivo de permitir ao utilizador carregar vários ficheiros PDF e obter um único PDF final resultante da junção

# PDFMerge

## Descrição
Aplicação web simples que permite ao utilizador carregar vários ficheiros PDF e obter, no final, um único ficheiro PDF resultante da junção desses documentos.

## API / biblioteca proposta
**PDFsharp**, utilizada para o processamento e combinação dos ficheiros PDF.

## Abordagem MVC
- **Model** → responsável pela representação dos ficheiros enviados, metadados dos documentos e resultado final da junção.
- **View** → interface onde o utilizador carrega os ficheiros PDF, acompanha o estado do processo e descarrega o ficheiro final.
- **Controller** → responsável por receber os pedidos, validar os ficheiros, coordenar o processo de junção e devolver o PDF final ao utilizador.

## Estrutura do repositório
- `/docs` → documentação de apoio ao projeto
- `/diagramas` → diagramas e modelação arquitetónica
- `/src` → código-fonte da aplicação
- `/entregas` → materiais finais e versões submetidas
