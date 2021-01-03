<?php

require_once 'user.php';

$pw = "asdf";

$pw2 = "adfdasfdga";

if(User::validatePassword($pw2))
{
    echo "Your password is long enough!";
}
else 
{
    echo "Your password is too short";
}


?>