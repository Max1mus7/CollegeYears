<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);


class Tire
{
    private $psi;
    public function __construct()
    {
        $this->psi = 32;
    }
    
    public function getPSI()
    {
        return $this->psi;
    }
    
    public function setPSI($newPSI)
    {
        $this->psi = $newPSI;
    }
}

?>