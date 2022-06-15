using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Interactions : MonoBehaviour
{
    public GameObject box;
    public Text text;
    string dialog;
    public bool range;
    public Animator anim;
    public GameObject player;
    public GameObject npc;
    public int scene;
    public static bool inter;
    public PlayableDirector timelineman;

    // Start is called before the first frame update
    IEnumerator ECoroutine()
    {
        yield return new WaitForSecondsRealtime(7);
        SceneManager.LoadScene("ThankYou");
    }

    // Update is called once per frame
    void Update()
    {
        scene = PlayerMove.scenenum;
        if (Input.GetKeyDown(KeyCode.Space) && range)
        {
            if (box.activeInHierarchy)
            {
                box.SetActive(false);
                inter = false;
                if (npc.name == "Scroll" && scene == 3)
                    npc.SetActive(false);
                if (npc.name == "Diary" && scene == 4)
                    npc.SetActive(false);
                if (npc.name == "Josh" && scene == 4)
                {
                    timelineman.Play();
                    StartCoroutine(ECoroutine());
                    //yield new WaitForSeconds((float)timelineman.duration);
                    
                }
                    
            }
            else
            {
                
                box.SetActive(true);
                inter = true;
                if (npc.name=="August")
                {
                    if (scene == 0)
                        dialog = npc.name + ": I'm sure that it was Darwin who committed that homicide. That's why I'm going to take him down.";
                    else if (scene == 1)
                        dialog = npc.name + ": Darwin is the only person I could see doing this.";
                    else if (scene == 2)
                        dialog = npc.name + ": Now that I think of it, Lord Jeffrey looks like the type of guy that would do something like this.";
                    else if (scene == 3)
                        dialog = npc.name + ": I don't think I could confront Lord Jeffrey about this. He's will destroy me, plus he's my master, I should not doubt him.";
                    else if (scene == 4)
                        dialog = npc.name + ": Lord Jeffrey is so scary!";
                }
                else if (npc.name == "Becca")
                {
                    if (scene == 0)
                        dialog = npc.name + ": After hearing what just happended, I'm probably going to move.";
                    else if (scene == 1)
                        dialog = npc.name + ": Could you please leave me alone? I have a lot of things in my mind.";
                    else if (scene == 2)
                        dialog = npc.name + ": There is too much stuff going on right now, I don't want to talk about it.";
                    else if (scene == 3)
                        dialog = npc.name + ": I have not heard anything on what happended today yet. If I hear something I'll let you know.";
                    else if (scene == 4)
                        dialog = npc.name + ": I'm so tired of this place, I want to quit.";
                }
                if (npc.name == "Darren")
                {
                    if (scene == 0)
                        dialog = npc.name + ": I cannot believe that something like this would happen.";
                    else if (scene == 1)
                        dialog = npc.name + ": I'm still in shock with the whole situation. It's unbelievable.";
                    else if (scene == 2)
                        dialog = npc.name + ": John usually deals with any rentals of books, scrolls or anything of that matter. So I would talk to him.";
                    else if (scene == 3)
                        dialog = npc.name + ": I just hope that this does not scare students or affect their grades.";
                    else if (scene == 4)
                        dialog = npc.name + ": I feel so sorry for everyone who is affected by this incident. Hopefully you can catch whoever did this.";
                }
                else if (npc.name == "Darwin")
                {
                    if (scene == 0)
                        dialog = npc.name + ": I don't know why this August guy is accusing me for what happened.";
                    else if (scene == 1)
                        dialog = npc.name + ": If anything, this just makes me think that he did it, even though I don't think he would do such a thing.";
                    else if (scene == 2)
                        dialog = npc.name + ": If I'm being honest, this Jeffrey guy is giving me the creeps. He has literally just been standing there this whole time.";
                    else if (scene == 3)
                        dialog = npc.name + ": If he commits a homicide in front of me, I'll allow it. But I'm definetely getting out of here.";
                    else if (scene == 4)
                        dialog = npc.name + ": Why is August shaking? He looks so scared.";
                }
                else if (npc.name == "Jeffrey")
                {
                    if (scene == 0)
                        dialog = npc.name + ": ...";
                    else if (scene == 1)
                    {
                        dialog = npc.name + ": I know who commited that murder. I will only tell you if you do me a favor. Give me the Scroll of the Beholder. Don't worry about what it is, just bring it to me.";
                        PlayerMove.scenenum++;
                    }
                    else if (scene == 2)
                        dialog = npc.name + ": I need that scroll!";
                    else if (scene == 3)
                        dialog = npc.name + ": You actually found it. Well a deal is a deal. The murderer goes by the name of Josh. Now begone I have work to do.";
                    else if (scene == 4)
                        dialog = npc.name + ": ...";
                }
                else if (npc.name == "Jesse")
                {
                    if (scene == 0)
                        dialog = npc.name + ": I thought this place was nice and quiet but I guess not.";
                    else if (scene == 1)
                        dialog = npc.name + ": When I was about to start patrolling, I did see this shadowy figure running to the right side of the campus.";
                    else if (scene == 2)
                        dialog = npc.name + ": Normally things are quiet around these parts but I guess times have changed.";
                    else if (scene == 3)
                        dialog = npc.name + ": There is this one creepy guy with red eyes that looks so suspicious.";
                    else if (scene == 4)
                        dialog = npc.name + ": If this murderer is never caught, I might have to find a different job because I don't want to be next.";
                }
                else if (npc.name == "John")
                {
                    if (scene == 0)
                    {
                        dialog = npc.name + ": I usually get here early in the morning and I did see a shadow by Model Hall that ran away towards the right.";
                        PlayerMove.scenenum++;
                    }   
                    else if (scene == 1)
                        dialog = npc.name + ": I have been the librarian for 42 years and this is the first time I have seen this happen.";
                    else if (scene == 2)
                        dialog = npc.name + ": The Scroll of the Beholder, I gave that to a student named Kelvin. I'm pretty sure he lives on campus.";
                    else if (scene == 3)
                        dialog = npc.name + ": I just don't know if things are going to be the same now.";
                    else if (scene == 4)
                        dialog = npc.name + ": It's probably time for me to retire. After 42 years, I think I have done enough and I should spent all my time with my family.";
                }
                else if (npc.name == "Josh")
                {
                    if (scene == 0)
                        dialog = npc.name + ": A murder? That's the least thing I would have expected to happen today.";
                    else if (scene == 1)
                        dialog = npc.name + ": I still cannot believe this.";
                    else if (scene == 2)
                        dialog = npc.name + ": My only concern is that Jeffrey guy, he seems so shady.";
                    else if (scene == 3)
                        dialog = npc.name + ": You think it's me who commited the murder because mister shady over there told you? This is ridiculous. Find some real evidence before accusing people.";
                    else if (scene == 4)
                        dialog = npc.name + ": Where did you find that? You need to stop invading my privacy. You will never take me alive!";
                }
                else if (npc.name == "Paige")
                {
                    if (scene == 0)
                        dialog = npc.name + ": I'm so scared, this situation is so scary.";
                    else if (scene == 1)
                        dialog = npc.name + ": I apologize, I just need a moment to calm myself down and then I'll give you the residence hall log.";
                    else if (scene == 2)
                        dialog = npc.name + ": Log: Room 1 at the top right, is occupied by Forrest. Room 2 at the top left, is occupied by Je-Mario. Room 3 at the bottom right, is occupied by Alex. Room 4 at the bottom left, is occupied by Kelvin.";
                    else if (scene == 3)
                        dialog = npc.name + ": I would repeat that log again but I'm having a hard time focusing because of what happended today.";
                    else if (scene == 4)
                        dialog = npc.name + ": I'm sorry, I'm taking the rest of the day off.";
                }
                else if (npc.name == "Ron")
                {
                    if (scene == 0)
                        dialog = npc.name + ": There was a murder? I didn't know. I have been working on my experiments all night.";
                    else if (scene == 1)
                        dialog = npc.name + ": Anything suspicious? Yesterday I did see a guy in dark clothes by the trees next to Swain but I'm not sure if that has to do with anything.";
                    else if (scene == 2)
                        dialog = npc.name + ": I should probably stop working and figure out exactly what happened out there.";
                    else if (scene == 3)
                        dialog = npc.name + ": Everything here is mine except that book over there. I believe that's Josh's diary or something.";
                    else if (scene == 4)
                        dialog = npc.name + ": I'm just going to stay and finish all my experiments.";
                }
                else if (npc.name == "Scott")
                {
                    if (scene == 0)
                        dialog = npc.name + ": The murder must have been early in the morning because it happended before I got here. Which if someone would have witnessed it, it would be John, the librarian.";
                    else if (scene == 1)
                        dialog = npc.name + ": Campus is shut down until further notice. Student and staff's safety is the number one priority.";
                    else if (scene == 2)
                        dialog = npc.name + ": This is going to affect Minot State's reputation. Hopefully students would still want to enroll here.";
                    else if (scene == 3)
                        dialog = npc.name + ": At least I get some more free time to grade your guy's bad code. Did I say that out loud? I'm just kidding.";
                    else if (scene == 4)
                        dialog = npc.name + ": I'm about to have a board meeting here soon.";
                }
                else if (npc.name == "Shan")
                {
                    if (scene == 0)
                        dialog = npc.name + ": In all my years of being in Minot State, I would have never guessed that this would happen.";
                    else if (scene == 1)
                        dialog = npc.name + ": I heard something like this happended in another university but I can't remember which one.";
                    else if (scene == 2)
                        dialog = npc.name + ": I'm pretty sure John, the librarian, would know about that scroll.";
                    else if (scene == 3)
                        dialog = npc.name + ": Kevin Cramer is speaking about the incident on the senate floor right now.";
                    else if (scene == 4)
                        dialog = npc.name + ": Wow. I'm still can't comprehend why anyone would do such a thing.";
                }
                else if (npc.name == "Scroll")
                {
                    if (scene == 0)
                        dialog = "A scroll written in an unknown language.";
                    else if (scene == 1)
                        dialog = "A scroll written in an unknown language.";
                    else if (scene == 2)
                    {
                        dialog = "You picked the scroll.";
                        PlayerMove.scenenum++;
                    }
                }
                else if (npc.name == "Diary")
                {
                    if (scene == 0)
                        dialog = "A diary, labeled: The Hit List.";
                    else if (scene == 1)
                        dialog = "A diary, labeled: The Hit List.";
                    else if (scene == 2)
                        dialog = "A diary, labeled: The Hit List.";
                    else if (scene == 3)
                    {
                        dialog = "You picked the diary.";
                        PlayerMove.scenenum++;
                    }
                }
                text.text = dialog;
                float dx = Mathf.Floor(npc.transform.position.x) - Mathf.Floor(player.transform.position.x);
                float dy = Mathf.Floor(npc.transform.position.y) - Mathf.Floor(player.transform.position.y);
                if (dx<1.5||dy<1.5)
                {
                    anim.SetFloat("PHorizontal", dx);
                    anim.SetFloat("PVertical", dy);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            range = true;
        }

    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            range = false;
        }

    }
}
