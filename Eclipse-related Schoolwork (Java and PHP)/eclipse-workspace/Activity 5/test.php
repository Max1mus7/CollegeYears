<?php
require_once 'BankBusinessService.php';


$b = new BankBusinessService();
echo "Checking Balance: " . $b->getCheckingBalance();
echo "<br><br>Savings Balance: " . $b->getSavingsBalance();
echo "<br><br>Transaction attempted.";
$b->transaction();
echo "Checking Balance: " . $b->getCheckingBalance();
echo "<br><br>Savings Balance: " . $b->getSavingsBalance();
?>