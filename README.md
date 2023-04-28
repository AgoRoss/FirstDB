# FirstDB
progetto in collegamento con database

progetto in collegamento con il plugin SQLite, che serve a collegarsi con un database per accedere a delle informazioni.
Si parla di RDBMS, rational database management system.
Dopo aver aperto il programma, vi è il file chinook.db: questo è il database con varie sezioni;
è possibile fare click destro, poi show table su una di queste sezioni per visualizzarne la tabella compilata.
Altrimenti si può aprire con il comando open database.

il problema è che il programma non riconosce i comandi associati al plugin, come SQLconnection;
questo perchè SQLlite non è un database ma una libreria(si vede sopra, "using SQLlite").
per capire quale libreria bisogna installare è necessario aprire il file .csproj;
qui dentro possiamo vedere alcuni "packagereference"; ovvero i pacchetti che sarebbero necessari
per far funzionare il programma. In questo caso SQLlite-net-pcl.
è possibile usare il comando dotnet. restore.
Si va nel terminale e si scrive dotnet add package SQLlite-net-pcl;
in questo modo viene automaticamente aggiunta la versione più nuova, se ne avessimo voluta
una specifica avremmo dovuto scrivere quale dopo il comando.
Si usa il comando
SQLiteconnection cn1 = new SQLiteconnection("chinook.db");
per la connessione al database.
Per selezionare da "Artist", però , è necessaria una classe; però è possibile anche creare
una classe vuota e il programma funzionerà lo stesso grazie alle classi anonime, introdotte
dal dotnet 4. Nella classe basta mettere public int artistid{get;set;}.
