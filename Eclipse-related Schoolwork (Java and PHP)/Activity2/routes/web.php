<?php

use App\Http\Controllers\TestController;

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

Route::get('/', function () {
    return view('welcome');
});

Route::get('/hello', function() {
    return "Hello World";
});

Route::get('/helloworld', function()
{
   return view('helloworld'); 
});

Route::get('/test', 'TestController@test2');

Route::post('/whoami','WhatsMyNameController@index');

Route::get('/askme', function () 
{ 
    return view('whoami'); 
}); 
?>