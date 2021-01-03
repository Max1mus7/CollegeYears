<?php

ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'myfuncs.php';
require_once 'session.php';

class orderDetails
{
    public $id;
    public $orderID;
    public $productID;
    public $productQuantity;
    public $currentPrice;
    public $currentDescription;
    
    function __construct()
    {
        
    }
    
    function getID()
    {
        return $this->id;
    }
    function getOrderID()
    {
        return $this->orderID;
    }
    function getProductID()
    {
        return $this->productID;
    }
    function getProductQuantity()
    {
        return $this->productQuantity;
    }
    function getCurrentPrice()
    {
        return $this->currentDescription;
    }
    function getCurrentDescription()
    {
        return $this->currentDescription;
    }

}
?>