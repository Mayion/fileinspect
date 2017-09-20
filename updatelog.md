#### [September 18, 2017]
> Methods are now retrievable in functions such as messagebox[] by enclosing them between round brackets and they go as follow (initial ones)
+ (file.size) [Returns integer value]
+ (file.md5) [Returns string value]
+ (file.sha1) [Returns string value]
+ (scan.type) [Returns integer value]
+ (scan.type.name) [Returns string]
+ (file.sections) [Returns array]

> Methods with **“Write”** capabilities have now been completely implemented, and that includes:
+ file.sections [Accepts only arrays]
+ scan.type [Accepts: default/or 0, advanced/or 1 or misc/or 2]
+ title = «input» [Changes the program’s main UI title to the input string]

Sections Snippet
```js
file.sections = .text//.data//.rdata
```

Scan Type Snippet
```js
scan.type = default
scan.type = advanced
scan.type = misc
```

Title Snippet
```js
title = This is the new title
```


#### [September 19, 2017]
+ Created the snippets folder to gradually add each sector of the code
+ Script arrays can now: Be compared against one another, Search for a value in them, Return all common values between two arrays.
