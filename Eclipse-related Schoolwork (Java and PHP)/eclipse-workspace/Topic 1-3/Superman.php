<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

require_once 'Superhero.php';
class Superman extends Superhero
{
    public function __construct()
    {
        parent::__construct("Superman", rand(1,100));
    }
}

?>