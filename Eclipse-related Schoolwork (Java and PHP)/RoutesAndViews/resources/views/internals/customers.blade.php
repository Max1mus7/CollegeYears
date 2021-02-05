@extends('layouts/layout')

@section('content')

<h1>Customers</h1>

<ul>
	<?php foreach($customers as $customer)
	{
	   echo '<li>' . $customer . '</li>';
	}?>
	
	@foreach ($customers as $customer)
		<li>{{ $customer }}</li>
	@endforeach
	
</ul>
@endsection