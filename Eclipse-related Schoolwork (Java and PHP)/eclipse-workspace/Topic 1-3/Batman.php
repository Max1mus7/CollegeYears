<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

require_once 'Superhero.php';
class Batman extends Superhero
{
    public function __construct()
    {
        parent::__construct("Batman", rand(1,100));
    }
}

?>