CSS or Cascading Style Sheets, is a programming language used to decorate a webpage. Its used to change the looks of everything you can see on a webpage. For example to add colour, change text size, or changing a grid/layout on a webpage.

There are multiple ways to add css in our HTML we will go over them one by one while going over some css:
```
<!DOCTYPE html>

<html lang="en">
	<head>
		<title>home</title>
	</head>
	<body>
		<p> John Harvard </p>
		<p> Welcome to my page! </p>
		<p> Copyright (c) John Harvard 1636 </p>
	</body>
</html>
```
Lets take this as an example,

## Font Size
All the paragraphs here will be laid out one by one which does not separate them, So we can change it like this:
``<p style="font-size: large;"> John Harvard </p>``
``<p style="font-size: medium;"> John Harvard </p>``
``<p style="font-size: small;"> John Harvard </p>``

As the name suggests it will change the paragraphs text size.

## Text-Align
``<p style="font-size: small; text-align: center;"> John Harvard </p>``

This will align the text to the centre of the page

# Style Tag
Another way to add css to a html page>

```
<!DOCTYPE html>

<html lang="en">
	<head>
		<style>
		
			body {
				text-align: center;
			}

			header{
				font-size: large;
			}

			main{
				font-size: medium;
			}

			footer{
				font-size: small;
			}
		</style>
		<title>home</title>
	</head>
	<body>
		<header> John Harvard </header>
		<main> Welcome to my page! </main>
		<footer> Copyright (c) John Harvard 1636 </footer>
	</body>
</html>
```

A style tag can only be added inside the head tags.

In this example we are using type selector, that is we use body{} to say we are selecting the body tag and that the body tag will use the properties defined inside body{}.

Another way we can do it:
```
<!DOCTYPE html>

<html lang="en">
	<head>
		<style>
			.centered {
				text-align: center;
			}

			.large{
				font-size: large;
			}

			.medium{
				font-size: medium;
			}

			.small{
				font-size: small;
			}
		</style>
		<title>home</title>
	</head>
	<body class="centered">
		<header class="large"> John Harvard </header>
		<main class="medium"> Welcome to my page! </main>
		<footer class="small"> Copyright (c) John Harvard 1636 </footer>
	</body>
</html>
```

This way of writing css makes it reusable, In this example we are defining these properties with a name for example the the ``text-align: center`` can be reused anywhere in the html by just adding a ``class="centered"`` attribute to it.

This way is known as ``Class Selector``

## Now to separate the HTML and the CSS code, Lets take an example:
Our HTML code can be (``Home.HTML``):
```
<!DOCTYPE html>

<html lang="en">
	<head>
		<link href="style.css" rel="stylesheet">
		<title>home</title>
	</head>
	<body class="centered">
		<header class="large"> John Harvard </header>
		<main class="medium"> Welcome to my page! </main>
		<footer class="small"> Copyright (c) John Harvard 1636 </footer>
	</body>
</html>
```
And our CSS code can be (``style.css``):
```
.centered {
	text-align: center;
}

.large{
	font-size: large;
}

.medium{
	font-size: medium;
}

.small{
	font-size: small;
}
```

In this way, we reference/import our css using ``<link href="style.css" rel="stylesheet">`` where ``rel="stylesheet"`` is just a way of telling the browser that this html file is referencing to ``href="style.css"`` for all the custom style.

