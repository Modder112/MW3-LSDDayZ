<?php

$empfaenger = $_POST["e"];
$betreff = $_POST["b"];
$nachricht = $_POST["m"];
$header = 'From: '.$_POST["f"] . "\r\n" .
    'Reply-To: '.$_POST["f"] . "\r\n" .
    'X-Mailer: PHP/' . phpversion();

mail($empfaenger, $betreff, $nachricht, $header);
?>