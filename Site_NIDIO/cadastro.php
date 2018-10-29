    <?php
    include_once ("conexao.php");
    $nome = $_POST['nome'];
    $nome_sobre = $_POST['sobrenome'];
    $idade = $_POST['idade'];
    $estado = $_POST['estado'];
    $cidade = $_POST['cidade'];
    $telefone = $_POST['telefone'];
    $estado_civil = $_POST['estado_civil'];
    $sexo = $_POST['sexo'];
    $sql = "insert into usuario(nome_pri, nome_sobre, idade, estado, cidade, telefone, estado_civil, sexo) values ('$nome',  '$nome_sobre',  '$idade',  '$estado',  '$cidade',  '$telefone',  '$estado_civil',  '$sexo')";
    $sql_busca = mysqli_query($conexao, "SELECT nome_pri FROM usuario");
    $salvar = mysqli_query($conexao, $sql);
    if(!$sql){
        print "Falha na conexão";
    }else{
        print "Deu certo";
    }
    mysqli_close($conexao);
    ?>