<?php 
//error reporting
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

//require necessary files once
require_once 'session.php';
require_once 'myfuncs.php';
require_once 'displayableProduct.php';


//create a cart class to keep track of users' items
class Cart
{
    //declare fields
    
    //keeps track of unique item IDs of items in the cart, linked to $productsQuantityArray
    private $productsIDArray;
    //keeps track of total items in the cart
    private $numItems;
    //keeps track of the quantities of each item in the cart, linked to $productsIDArray
    private $productsQuantityArray;
    
    //no-args constructor
    public function __construct()
    {
        $_SESSION['cartItems'] = 0;
        $this->productsIDArray = array();
        $this->numItems = 0;
        $this->productsQuantityArray = array();
    }
    
    //returns the amount of items in the cart
    public function getNumItems()
    {
        return $this->numItems;
    }
    
    //returns the array of IDs of products held in the cart
    public function getProductsIDArray()
    {
        return $this->productsIDArray;
    }
    
    //returns the array of quantities of items held in the cart
    public function getProductsQuantityArray()
    {
        return $this->productsQuantityArray;
    }
    
    //function to add a product to the cart
    public function addItem($productID)
    {
        $alreadyExists = false;
        $index = 0;
        // first check to see if this product id is already in the cart.
        for($i = 0; $i < count($this->productsIDArray); $i++)
        {
            if($this->productsIDArray[$i] == $productID)
            {
                $alreadyExists = true;
                $index = $i;
            }
        }
        //if yes, add one to cart
        if($alreadyExists)
        {
            $this->productsQuantityArray[$index]++;
            $_SESSION['cartItems'] = $_SESSION['cartItems'] + 1;
        }
        //if no, add a new item to the products array
        else 
        {
            $this->productsIDArray[] = $productID;
            $this->productsQuantityArray[] = 1;
            $this->numItems++;
            $_SESSION['cartItems'] = $_SESSION['cartItems'] + 1;
        }
    }
    
    public function addMultipleItems($productID, $newItems)
    {
        $this->productsQuantityArray[$productID] += $newItems;
    }
    
    //function to change the quantity of a specific product in the cart
    public function updateQuantity($productID, $newQuantity)
    {
        for($i = 0; $i < count($this->productsIDArray); $i++)
        {
            if ($this->productsIDArray[$i] == $productID) 
            {
                $this->productsQuantityArray[$i] = $newQuantity;
            }
        }
    }
    
    //function to remove an item from the cart
    public function removeItem($id)
    {
        unset($this->productsIDArray[$id]);
        $this->productsIDArray = array_values($this->productsArray);
    }
    
    //function to clear the cart, either after checkout or by user decision
    public function clearCart()
    {
        foreach ($this->productsIDArray as $i => $value) 
        {
            unset($this->productsIDArray[$i]);
        }
        $this->productsIDArray = array_values($this->productsIDArray);
        foreach ($this->productsQuantityArray as $s => $item)
        {
            unset($this->productsQuantityArray[$s]);
        }
        $this->productsQuantityArray = array_values($this->productsQuantityArray);
        $this->numItems = 0;
        $_SESSION['cartItems'] = 0;
    }
}

?>