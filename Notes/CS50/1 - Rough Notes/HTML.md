## Basics:
- Its not a programming language, meaning it does not contains methods or variables.

- HTML (Hyper Text Markup Language) : It has main two features:
	- tags
	- attributes
	
## Taking and example:
```
<!DOCTYPE html>

<html lang="en">
	<head>
		<title>
			Hello, title
		</title>
	</head>
	<body>
		hello, body
	</body>
</html>
```

Now we can use a http-server (A server is just a software running on a machine, whose purpose in life is to just handle requests and serve data) to host this html page.

I used VisualStudios **Live Server** extension to host my test.html file with the code block above^

## Focusing on the html code: 
-  `<!DOCTYPE html>` **DOCUMENT TYPE**: This is our document type declaration, its an implicit indicator to the browser that the this file is using the latest version of html (which is version 5). 

- `<html lang="en"> ... </html>` **HTML TAG**  : This is a tag in html, the tag name in this context is html. The tags used in html will generally have a closing tag like this : `</html>` unlike `<!DOCTYPE html>` which is a type declaration (not a tag) and therefore will not have a closing statement.
	- The `lang="en` part in the code is an attribute, which are similar to function arguments but they are not exactly that. In this context it tells the browser that everything inside html is in english.

- `<head>`, `<title>`, `<body>`: **HEAD, TITLE and BODY TAGS** :  All these tags are children and grand child of the html tag. Each of them individually define individual sections inside a web page.


## Key Tags:
- `<br>` **BREAK TAG** : It can be used mid text, and it moves the cursor to the next line. Like most tags in HTML this doesn't require a closing tag.

- `<p>`   **PARAGRAPH TAG** : Sets a block of text as a paragraph. It has a closing tag.

- `<ul>` **UNORDERED LIST** : dotted list. 
Example Syntax: 
```
<ul>
	<li>foo</li>
	<li>bar</li>
	<li>baz</li>
</ul>
```

- `<ol>` **ORDERED LIST** :  Numbered List
Example Syntax:
```
<ol>
	<li>foo</li>
	<li>bar</li>
	<li>baz</li>
</ol>
```

- `<table>` **TABLE TAG** : Create a table with data
Example Synatx:
```
<table>
	<tr>
		<td>1</td>
		<td>2</td>
		<td>3</td>
	</tr>
	<tr>
		<td>4</td>
		<td>5</td>
		<td>6</td>
	</tr>
	<tr>
		<td>7</td>
		<td>8</td>
		<td>9</td>
	</tr>
	<tr>
		<td>*</td>
		<td>0</td>
		<td>#</td>
	</tr>
</table>
```

-  