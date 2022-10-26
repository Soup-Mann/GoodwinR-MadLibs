using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_MadLibs.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
[HttpGet]
    [Route("{time}/{person}/{feeling}/{place}/{vehicle}/{celebrity}/{restaurant}/{person2}/{objected}/{musician}")]
    public string gayballs(string person, string time, string feeling, string place, string vehicle, string restaurant, string person2, string objected, string musician, string celebrity){
        
    return $"One fine {time} our protagonist {person}  was feeling {feeling} so they decided to  go for a drive to {place}. They get in a start driving, while on the road they stop for gas and spot {celebrity}. 'Hey! Im a huge fan!' {person} Says excitedly! {celebrity} walks up and asks to join you on the drive! You both get in a keep Cruisin, While driving {celebrity} Calls {person2} and Invited them to come along! They pick up {person2} and continue their drive! They arrive in {place} and they decide to go to the restaurant, {restaurant} They sat down and while they were eating they spotted {musician} and {celebrity} invites them over to join. {musician} walks over, sits down, and pulls out an {objected} and sets it on the table to see everyones reaction. 'Woah how did you get that?' {celebrity} asked. 'Found it' {musician} says, then {musician} gets up to use the bathroom and {person2} immediatley grabs the {objected} and gets up to leave, {person} and {celebrity} both get up and follow, they get outside and {person2} throws the {objected} into the street and runs off. Deciding to distamce themselves from the situation {person} and {celebrity} decide to head home. ";
    

}
}
