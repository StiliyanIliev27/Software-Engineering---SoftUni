function city(city){
    const entries = Object.entries(city);
    for(let [key, value] of entries){
        console.log(`${key} -> ${value}`);
    }
}   

city({
    name: "Sofia",
    area: 492,
    population: 1238438,
    country: "Bulgaria",
    postCode: "1000"
});