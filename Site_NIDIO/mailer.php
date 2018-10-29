<?php
    use PHPMailer\PHPMailer\PHPMailer;
    use PHPMailer\PHPMailer\Exception;
    
    require 'PHPMailer/src/Exception.php';
    require 'PHPMailer/src/PHPMailer.php';
    require 'PHPMailer/src/SMTP.php';

    $Mailer = new PHPMailer(true);
    try{
    $Mailer->isSMTP();
    $Mailer->Host = 'smtp.gmail.com';
    $Mailer->isHTML(true);

    $Mailer->Charset = 'UTF8';

    $Mailer->SMTPAuth = true;
    $Mailer->SMTPSecure = 'tls';
    $Mailer->Username = 'thereicesar@gmail.com';
    $Mailer->Password = 'l@liluleilou';
    $Mailer->Port = 587;

    $Mailer->setFrom('thereicesar@gmail.com');
    //$Mailer->FromName = 'Nidio';

    $nome = $_POST['name'];
    $email = $_POST['email'];
    $mensagem = $_POST['message'];

    $Mailer->AddAddress($email);
    $Mailer->Subject = 'Teste de envio de email - Nidio';
    $Mailer->Body = $mensagem;
    $Mailer->AltBody = 'conteúdo do email';
    $Mailer->Send();
        echo "E-Mail enviado com sucesso";
    }catch(Exception $e){
        echo 'Erro no envio do email'.$Mailer->ErrorInfo;
    }
?>