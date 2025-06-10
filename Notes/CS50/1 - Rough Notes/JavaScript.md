- Its a programming language used for the web browser.
- It allows us to dynamically alter the HTML data at runtime.
## Declaring a variable
```
let constant = 10;
```

## Incrementing 
```
constant++;
```
OR
```
constant = constant + 1;
```
OR
```
constant += 1;
```

## Loop
```
for(let i=0;i<10;i++){

}
```

- Implementing js with html
Example:
```
<html>
	<head>
		<title>
			hello, title
		</title>
	</head>
	<body>
		<form>
			<input autocomplete="off" autofocus id="name" placeholder="Name" type="text">
			<button type="submit">Greet</button>
		</form>
		<script>
			document.querySelector('form').addEventListener('submit', function(event){
				let name=document.querySelector('#name').value;
				alert('hello, '+name);
				event.preventDefault();
			});
		</script>
	</body>	
</html>
```