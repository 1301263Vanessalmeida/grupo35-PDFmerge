## Caso 1 — seleção de ficheiros

Quando o utilizador seleciona os PDFs, isso dispara um evento na View (por exemplo OnFilesSelected).  
O Controller está a “ouvir” esse evento e, quando acontece, pega nos ficheiros e manda para o Model validar.  
Assim a View não fala diretamente com o Model, o que reduz o acoplamento.

## Caso 2 — resultado da junção

Depois de o Model juntar os PDFs, dispara um evento do tipo OnMergeCompleted.  
A View recebe esse evento e mostra o resultado (PDF pronto para download).  
Aqui o Model também não depende da View diretamente.
