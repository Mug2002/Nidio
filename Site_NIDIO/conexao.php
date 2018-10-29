   <?php
    $host = "localhost";
    $user = "root";
    $pass = "";
    $banco = "cadastro";
    $conexao = mysqli_connect($host, $user, $pass, $banco) or die (mysql_error());
    if(!$conexao){
        print "Falha na conexão";
    }else{
        print "Deu certo";
    }
    ?>