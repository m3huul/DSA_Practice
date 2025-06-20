## Basics:
- Its not a programming language, meaning it does not contains methods or variables.

- HTML (Hyper Text Markup Language) : It has main two features:
	- tags
	- attributes
	
## Taking an example:
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
Example Syntax:
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

- `<img src="">` **IMAGE TAG** : The src brackets will have the location of the image.
	- It also has an `alt` tag short for 'alterante' text, Its to tell the browser or for the blind users to read the website. Used like: 
```
<img alt="Harvard Uni" src="harvard.jpg">
```

- `<video autoplay loop muted width="1280"> <source src="" type="video/mp4> </video>` **VIDEO TAG** : Default Video Player of the browser. autoplay, loop and muted are default parameters which can be altered with different values to change the video players behaviour. 

- `<a href=""> </a>` **ANCHOR TAG** : Place a text in between the tags to make the text a hyperlink.

- `<meta name="viewport" content="width=device-width, initial-scale=1.0">` **META TAG** : Its set inside the head tag which basically makes the site responsive by adjusting the layout based on the screen width.
Example:
```
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta name="description" content="A brief description of the page">
	<meta name="author" content="Your Name">
	
	<meta property="og:title" content="My Awesome Web Page">
	<meta property="og:description" content="This is a brief description of my awesome web page.">
	<meta property="og:image" content="https://example.com/image.jpg">
	<meta property="og:url" content="https://example.com/page">
	<title>Page Title</title>
</head>
<body>
	<!-- Page content -->
</body>
</html>
```
- `<meta charset="UTF-8">` : Sets the character encoding. `UTF-8` is the most widely used and supports most characters.
- `<meta name="description" content="...">` : Gives search engines a summary of the page’s content (used in search result snippets).
- `<meta name="author" content="...">` : Indicates the author of the page.
- `property` : Defines the Open Graph property. Popup when someone hovers over the link to this html page.
- `content` : Specifies the value of the property.


- `<form>` **FORM TAG** : A search box.
Example:
```
<form action="https://www.google.com/search">
	<input name="q" type="search">
	<input type="submit">
</form>
```
A form tag will give us a input field. In our current example we have a form tag with type = "search" which just gives us a clear (x) button for the input field, name is just "q" short for query. type = "submit" denotes the forms button with "Submit" text. the action on the top will define that whenever the submit button is clicked it will search the url with input given in the form input field.
Example:
```
<form action="https://www.google.com/search">
	<input name="q" type="search">
	<input type="submit" value="Google Search">
</form>
```
To change the buttons name we can add a value with the submit type.
Example:
```
<form action="https://www.google.com/search">
	<input autocomplete="off" autofocus name="q" placeholder="Query" type="search">
	<input type="submit" value="Google Search">
</form>
```
`autocomplete = "off"` Set to off will make it so no suggestions from previous entries will be shown to the user.
`autofocus` Will make it so the input field is automatically focused when page is loaded.
`placeholder = "Query"` This means if no text is written by the user in the input field then it would show "Query" there as a placeholder text, to guide user about the form.