![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/colorBar1.PNG "Colors")

# the color wheel api
> **the** api for all of your color palette needs!

![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/colorBar2.PNG "Colors")

## table of contents
* [purpose](#purpose)
* [summary](#summary)
* [endpoints](#endpoints)
* [methods](#methods)
* [schema](#schema)
* [notes](#notes)
* [versions](#versions)
* [authors](#authors)
* [license](#license)



## purpose:
```
	This API exists to hopefully make live a little simpler for anyone that works with color.
	Send a color to one of our many endpoints and receive a color palette back, complete with the color name and hex codes.
```

## summary
```
	The Color Wheel API provides color palettes based on user input and the color wheel.
	Each endpoint takes a color name and returns a JSON object for their specific color scheme:
		- GetAnalogousPalette: Returns an [analogous palette](https://en.wikipedia.org/wiki/Analogous_colors).
		- GetComplementaryPalette: Returns a [complementary palette](https://en.wikipedia.org/wiki/Complementary_colors).
		- GetSplitComplementaryPalette: Returns [split complementary palette](https://en.wikipedia.org/wiki/Color_scheme#Complementary).
		- GetTetradicPalette: Returns [tetradic palette](https://en.wikipedia.org/wiki/Color_scheme#Tetradic).
		- GetTriadicPalette: Returns [triadic palette](https://en.wikipedia.org/wiki/Color_scheme#Triadic).
```

## endpoints
### getanalogouspalette
#### request
`	https://colorwheelapi20190205024526.azurewebsites.net/api/GetAnalogousPalette/Red `

#### response
![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/getAnalogousResponse.PNG "GetAnalogousPalette")

### getcomplementarypalette
#### request
`	https://colorwheelapi20190205024526.azurewebsites.net/api/GetComplementaryPalette/Red `

#### response
![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/getComplementaryResponse.PNG "GetAnalogousPalette")

### getsplitcomplementarypalette
#### request
`	https://colorwheelapi20190205024526.azurewebsites.net/api/GetSplitComplementaryPalette/Red `

#### response
![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/getSplitComplementaryResponse.PNG "GetAnalogousPalette")

### gettetradicalette
#### request
`	https://colorwheelapi20190205024526.azurewebsites.net/api/GetTetradicPalette/Red `

#### response
![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/getTetradicResponse.PNG "GetAnalogousPalette")

### gettriadicpalette
#### request
`	https://colorwheelapi20190205024526.azurewebsites.net/api/GetTriadicPalette/Red `

#### response
![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/getTriadicResponse.PNG "GetAnalogousPalette")


## methods
* GET
* PUT
* POST
* DELETE


## schema
![](assets/MidtermTables.PNG?raw=true)

## notes


## versions:
```
Version 1.0  February 01, 2019
Version 1.4 February 05, 2019
```


## authors
* **Carlos Castillo** - *Initial work* - [castillocarlosr](https://github.com/castillocarlosr])
* **Charles Clemens** - *Initial work* - [CClemensJr](https://github.com/CClemensJr)

## license
```
	This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
```