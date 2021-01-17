let array = ["Aleksandar", "Calm", "Active"];

function tellStory(name, mood, activity){
    let names = array[0];
    let moods= array[1];
    let activitys = array[2];

    let story = console.log(`This is ${names}. ${names} is a nice person. Today they are ${moods}. They are ${activitys} all day. The end.`);

    return story;

    
}

tellStory();