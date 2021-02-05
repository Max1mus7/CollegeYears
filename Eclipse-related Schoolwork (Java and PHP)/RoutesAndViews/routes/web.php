<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () 
{
    return view('welcome');
});

Route::get('/basic_response', function () 
{
    return "Hello World";
});

Route::get('/header', function ()
{
    return response("Hello to everyone in CST-256!", 200)->header('Content-Type', 'text/html');
});

Route::get('/test', function ()
{
    return view('test');
});

//function can be used to return parameters from URL
Route::get('contact', function()
{
    //Make sure to only use the name of the view in the views directory
    return view('contact');
});

Route::get('about', function()
{
    //Make sure to only use the name of the view in the views directory
    return view('about');
});

Route::get('customers', function()
{
    $customers = ['John Doe', 'Jane Doe', 'Bob The Builder'];
    return view('internals.customers', ['customers' => $customers]);
});

Route::get('products', function()
{
    $products = ['twizzlers', 'red vines', 'hershey bar', 'payday', 'milk duds'];
    return view('products', ['products' => $products]);
});

