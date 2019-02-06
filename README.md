![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/colorBar1.jpg "Colors")

# the color wheel api
> **the** api for all of your color palette needs!

![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/colorBar2.jpg "Colors")

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
	Send a color to one of our many endpoints and receive a color palette back, complete with the color name and hex codes
```

## summary:
- The API will have several tables with Primary and Foreign keys matches with the tables
- A request sent out to the table first checks the color table if color exsist.
- If not null, the color with follow one of six paths made by the front end point.
- The matching table is then access and the data containing the matching color is returned to the front-end point.
- Future updates may be made to this API.

## endpoints
- **api/Get(PaletteName)Palette/(Color)**
- Format needed for the request should be Capital first letter and the rest lower-case.  ex. Green
ex. Triadic
- For hybrid color, a dash is required between the two colors. ex Blue-Green
- example:  
```
{
    "id": 2,
    "colorOneID": 2,
    "colorTwoID": 6,
    "colorThreeID": 10,
    "color": {
        "id": 2,
        "colorName": "Yellow-Green",
        "hexCode": "#B2D732"
    "color": {
        "id": 6,
        ...............       
    }
}
```
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