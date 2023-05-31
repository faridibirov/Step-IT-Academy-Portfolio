// ------------- Task 1 -----------

// function Changer ( text)
// {
//     let result= [];

//     for(let i =0; i< text.length; i++)
//     {
//         if(/^\d+$/.test(text[i]))
//         {
//             result.push('_')
//         }

//        else if (text[i].toUpperCase()===text[i])
//         {
//             result.push(text[i].toLowerCase())
//         }

//        else if (text[i].toLowerCase()===text[i])
//         {
//             result.push(text[i].toUpperCase())
//         }

//         else {
//             result.push(text[i]);
//           }

//     }

//     return result.join('');
// }


// console.log(Changer("fARID dIBIROV 123"));






// ------------- Task 2 -----------

// function ShowUrlInfo(url)
// {
//     let protocol = []
//     let domen = []
//     let path = []
//     let path2=[]

//   protocol = url.split("://");
//   protocol = protocol[0];

//   console.log(protocol);

//   domen = url.split("/");

//   domen = domen[2];

//   console.log(domen);

//   path = url.split("/");

//   for (let i=3; i<path.length; i++)

//   {
//     path2.push(path[i])
//   }
  
//   console.log(path2.join('/'));
// }


// ShowUrlInfo("https://itstep.org/ua/about");



// ------------- Task 3 -----------

// let receipt = [
//     { name: "Banana", count: 2, price: 3.50 },
//     { name: "Bread", count: 1, price: 1 },
//     { name: "Beer", count: 5, price: 2.5},
//     { name: "Cola", count: 1, price: 2.3},
    
//   ];

  
//   function Showreceipt ()
//   {
//     for (item of receipt)
//     {
//         console.log(`Product name: ${item.name}`)
//         console.log(`Product count: ${item.count}`)
//         console.log(`Product price: ${item.price}`)
//         console.log("---------------------")
//     }
//   }


//   function Totalamount ()
//   {
//     let total =0

//     for (item of receipt)
//     {
//         total+=item.price*item.count;
//     }

//     console.log(`Total amount: ${total}`)
//   }


//   function Maxamount ()
//    {
//         let max = 0;

//         for (item of receipt)
//         {
//             if (max<(item.price*item.count))
//             max = item.price*item.count;
//         }
    
//         console.log(`Max amount in receipt: ${max}`)

//    }



//    function Average ()
//    {
//         let avarage = 0;
//         let totalcount=0;
//         let sum =0;

//         for (item of receipt)
//         {
//             sum += item.count*item.price
//             totalcount+=item.count;
//         }

//         avarage=sum/totalcount;
    
//         console.log(`Avarage amount of products: ${Math.round(avarage*10)/10}`)

//    }


// ------------- Task 4 -----------


// const stylearray = [

//     {name:"color", value:"red"},
//     {name:"font-size", value:"30px"},
//     {name:"text-align", value:"center"},
//     { name: "font-weight", value: "900" },
// ]

// function textFormat(arr, text)
// {
//     document.write(`<p style="`)

//     for(let item of arr)
//     {
//         document.write(`${item.name}:${item.value};`)
//     }

//     document.write(`",>${text}</p>`)
// };


// textFormat(stylearray, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reprehenderit, rem sit eaque temporibus sint explicabo.")





// ------------- Task 5 -----------

// car = {
    
//     mark:"Merdeces", model:"C180", year:1998, avspeed:60,

//   ShowInfo()
// {
//             document.write(
//                 `
//                 <p>Mark: ${car.mark}</p>
//                 <p>Model: ${car.model}</p>
//                 <p>Year: ${car.year}</p>
//                 <p>Average Speed: ${car.avspeed}</p>
//                 <hr/>
//                 `
//             )

// },

// Hrscounter(distance)
// {
//     let hours = distance / this.avspeed;
//           if (hours % 4 === 0) {
//             return hours + Math.floor((hours - 1) / 4);
//           }
//           return hours + Math.floor(hours / 4);
// }

// } 

// car.ShowInfo()

// document.write(car.Hrscounter(500));