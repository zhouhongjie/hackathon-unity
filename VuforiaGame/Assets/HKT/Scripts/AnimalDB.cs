using UnityEngine;
using System.Collections;

public class AnimalDB : SingletonMonoBehaviour<AnimalDB>
{
		[HideInInspector]
		public GameObject
				currentAnimal;
		[HideInInspector]
		public string[]
				name = new string[] {
			"BEAR",
			"BOAR",
			"CHICKEN",
			"COW",
			"CROCODILE",
			"ELEPHANT",
			"FOX",
			"GOAT",
			"HIPPOPOTAMUS",
			"LION",
			"PIG",
			"RABBIT",
			"RHINOCEROS",
			"SHEEP",
			"STAG",
			"WOLF",
			"ZEBRA"
		};
		[HideInInspector]
		public string[]
				info = new string[] {
		"Bears are mammals of the family Ursidae. Bears are classified as caniforms, or doglike carnivorans, with the pinnipeds being their closest living relatives. Although only eight species of bears are extant, they are widespread, appearing in a wide variety of habitats throughout the Northern Hemisphere and partially in the Southern Hemisphere. Bears are found on the continents of North America, South America, Europe, and Asia \n" +
				"Common characteristics of modern bears include large bodies with stocky legs, long snouts, shaggy hair, plantigrade paws with five nonretractile claws, and short tails. While the polar bear is mostly carnivorous, and the giant panda feeds almost entirely on bamboo, the remaining six species are omnivorous with varied " +
				"diets.",
		"The wild boar (Sus scrofa), also known as the wild swine[3] or Eurasian wild pig[4] is a suid native to much of Eurasia, North Africa and the Greater Sunda Islands. Human intervention has spread its range further, thus making the species one of the widest ranging mammals in the world, as well as the most widely spread suiform.[4] Its wide range, high numbers and adaptability mean that it is classed as least concern by the IUCN.\n" +
				"As of 2005, up to 16 subspecies are recognised, which are divided into four regional groupings based on skull height and lacrimal bone length.[2] The species lives in matriarchal societies consisting of young males, intrarelated females and their young. Fully grown males are usually solitary outside of the breeding season.[5] The grey wolf is the wild boar's main predator throughout most of its range except in the Far East, where it is replaced by the tiger.[6] It has a long history of association with humans, having been the ancestor of most domestic pig breeds and a big game animal for\n" +
				"millennia.",
		"The chicken (Gallus gallus domesticus) is a domesticated fowl, a subspecies of the Red Junglefowl. As one of the most common and widespread domestic animals, with a population of more than 24 billion in 2003,[1] there are more chickens in the world than any other species of bird. Humans keep chickens primarily as a source of food, consuming both their meat and their eggs.+\n" +
				"The traditional poultry farming view of the domestication of the chicken is stated in Encyclopædia Britannica (2007).Humans first domesticated chickens of Indian origin for the purpose of cockfighting in Asia, Africa, and " +
				"Europe.",
		"Cattle (colloquially cows) are the most common type of large domesticated ungulates. They are a prominent modern member of the subfamily Bovinae, are the most widespread species of the genus Bos, and are most commonly classified collectively as Bos taurus. Cattle are raised as livestock for meat (beef and veal), as dairy animals for milk and other dairy products, and as draft animals (oxen or bullocks) (pulling carts, plows and the like). Other products include leather and dung for manure or fuel. In some regions, such as parts of India, cattle have significant religious meaning. From as few as 80 progenitors domesticated in southeast Turkey about 10,500 years ago.[1] According to an estimate from 2003, there are 1.3 billion cattle in the world.[2] In 2009, cattle became the first livestock animal to have a fully mapped " +
				"genome.[3]",
		"Crocodiles (subfamily Crocodylinae) or true crocodiles are large aquatic reptiles that live throughout the tropics in Africa, Asia, the Americas and " +
				"Australia.",
		"Elephants are large mammals of the family Elephantidae and the order Proboscidea. Two species are traditionally recognised, the African elephant (Loxodonta africana) and the Asian elephant (Elephas maximus), although some evidence suggests that African bush elephants and African forest elephants are separate species (L. africana and L. cyclotis respectively). Elephants are scattered throughout sub-Saharan Africa, South Asia, and Southeast" +
				"Asia",
		"Foxes are small-to-medium-sized, omnivorous mammals belonging to several genera of the Canidae family. Foxes are slightly smaller than a medium-size domestic dog, with a flattened skull, upright triangular ears, a pointed, slightly upturned snout, and a long bushy tail " +
				"(or brush).",
		"The domestic goat (Capra aegagrus hircus) is a subspecies of goat domesticated from the wild goat of southwest Asia and Eastern " +
				"Europe. ",
		"The hippopotamus (Hippopotamus amphibius), or hippo, is a large, mostly herbivorous mammal in sub-Saharan Africa, and one of only two extant" +
				"species. ",
		"The lion (Panthera leo) is one of the five big cats in the genus Panthera and a member of the family Felidae. With some males exceeding 250 kg (550 lb) in weight,[4] it is the second-largest living cat after the tiger. Wild lions currently exist in sub-Saharan Africa and in Asia (where an endangered remnant population resides in Gir Forest National Park in India) while other types of lions have disappeared from North Africa and Southwest Asia in historic times. Until the late Pleistocene, about 10,000 years ago, the lion was the most widespread large land mammal after humans. They were found in most of Africa, across Eurasia from western Europe to India, and in the Americas from the Yukon to " +
				"Peru.[5]",
		"A pig is any of the animals in the genus Sus, within the Suidae family of even-toed ungulates. Pigs include the domestic pig and its ancestor, the common Eurasian wild boar (Sus scrofa), along with other species; related creatures outside the genus include the babirusa and the warthog. Pigs, like all suids, are native to the Eurasian and African continents. Juvenile pigs are known as piglets.[1] Pigs are omnivores and are highly social and intelligent " +
				"animals.[2]",
		"Rabbits are small mammals in the family Leporidae of the order Lagomorpha, found in several parts of the world. There are eight different genera in the family classified as rabbits, including the European rabbit (Oryctolagus cuniculus), cottontail rabbits (genus Sylvilagus; 13 species), and the Amami rabbit (Pentalagus furnessi, an endangered species on Amami Ōshima, Japan). There are many other species of rabbit, and these, along with pikas and hares, make up the order Lagomorpha. The male is called a buck and the female is a doe; a young rabbit is a kitten " +
				"or kit.",
		"Rhinoceros /raɪˈnɒsərəs/, often abbreviated as rhino, is a group of five extant species of odd-toed ungulates in the family Rhinocerotidae. Two of these species are native to Africa and three to Southern Asia.\n" +
				"Members of the rhinoceros family are characterized by their large size (they are some of the largest remaining megafauna, with all of the species able to reach one tonne or more in weight); as well as by an herbivorous diet; a thick protective skin, 1.5–5 cm thick, formed from layers of collagen positioned in a lattice structure; relatively small brains for mammals this size (400–600 g); and a large horn. They generally eat leafy material, although their ability to ferment food in their hindgut allows them to subsist on more fibrous plant matter, if necessary. Unlike other perissodactyls, the two African species of rhinoceros lack teeth at the front of their mouths, relying instead on their lips to pluck " +
				"food.[1]",
		"Sheep (Ovis aries) are quadrupedal, ruminant mammals typically kept as livestock. Like all ruminants, sheep are members of the order Artiodactyla, the even-toed ungulates. Although the name applies to many species in the genus Ovis, in everyday usage it almost always refers to Ovis aries. Numbering a little over one billion, domestic sheep are also the most numerous species of sheep. An adult female sheep is referred to as a ewe (/juː/), an intact male as a ram or occasionally a tup, a castrated male as a wether, and a younger sheep as a" +
				"lamb.",
		"The stag-moose (Cervalces scotti) was a large moose, with a muzzle more closely resembling that of a typical deer,[1] of North America during the Pleistocene epoch.[2] It is the only known North American member of the genus " +
				"Cervalces.",
		"The gray wolf (Canis lupus[a]) also known as the timber wolf,[3][4] or western wolf,[b] is a canid native to the wilderness and remote areas of North America, Eurasia, and northern, eastern and western Africa. It is the largest extant member of its family, with males averaging 43–45 kg (95–99 lb), and females 36–38.5 kg (79–85 lb).[6] Like the red wolf, it is distinguished from other Canis species by its larger size and less pointed features, particularly on the ears and muzzle.[7] Its winter fur is long and bushy, and predominantly a mottled gray in color, although nearly pure white, red, or brown to black also occur.[4] As of 2005,[8] 37 subspecies of C. lupus are recognised by MSW3. The nominate subspecies is the Eurasian wolf (Canis lupus lupus),[9] also known as the common" +
				"wolf.[10]",
		"Zebras (/ˈzɛbrə/ zeb-rə or /ˈziːbrə/ zee-brə)[1] are several species of African equids (horse family) united by their distinctive black and white striped coats. Their stripes come in different patterns, unique to each individual. They are generally social animals that live in small harems to large herds. Unlike their closest relatives, horses and donkeys, zebras have never been truly " +
				"domesticated."
	};
}

