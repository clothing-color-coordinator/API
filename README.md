![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/colorBar1.jpg "Colors")

# Color Wheel API

An API for a color wheel color matching based on matching color theory.

![alt text](https://github.com/clothing-color-coordinator/API/blob/master/assets/colorBar2.jpg "Colors")

## Purpose:
```
This is a personal made API.
A color is requested to the API.
The API matches a color that is requested to this API in a JSON file.
```

## Summary:
- The API will have several tables with Primary and Foreign keys matches with the tables
- A request sent out to the table first checks the color table if color exsist.
- If not null, the color with follow one of six paths made by the front end point.
- The matching table is then access and the data containing the matching color is returned to the front-end point.
- Future updates may be made to this API.

## API Functions (JSON format)
* GET
* PUT
* POST
* DELETE

## EndPoints
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


#### Version:
```
Version 1.0  February 01, 2019
Version 1.4 February 05, 2019
```

## Schema Table
![](assets/MidtermTables.PNG?raw=true)

## Collaberators
* [Carlos Castillo](#castillocarlosr)
* [Charles Clemens](#CClemensJr)