﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DataDownloader.Common.Resources
{
    public class SupportedLanguages
    {
        public static IEnumerable<Language> Languages => AllLanguages.Where(language => language.Supported);
        public static IEnumerable<Language> AllLanguages { get; } = new List<Language>
        {
            new Language(false,"Abkhaz","аҧсуа бызшәа, аҧсшәа","ab","abk","abk"),
            new Language(false,"Afar","Afaraf","aa","aar","aar"),
            new Language(false,"Afrikaans","Afrikaans","af","afr","afr"),
            new Language(false,"Akan","Akan","ak","aka","aka"),
            new Language(false,"Albanian","Shqip","sq","sqi","alb"),
            new Language(false,"Amharic","አማርኛ","am","amh","amh"),
            new Language(false,"Arabic","العربية","ar","ara","ara"),
            new Language(false,"Aragonese","aragonés","an","arg","arg"),
            new Language(false,"Armenian","Հայերեն","hy","hye","arm"),
            new Language(false,"Assamese","অসমীয়া","as","asm","asm"),
            new Language(false,"Avaric","авар мацӀ, магӀарул мацӀ","av","ava","ava"),
            new Language(false,"Avestan","avesta","ae","ave","ave"),
            new Language(false,"Aymara","aymar aru","ay","aym","aym"),
            new Language(false,"Azerbaijani","azərbaycan dili","az","aze","aze"),
            new Language(false,"Bambara","bamanankan","bm","bam","bam"),
            new Language(false,"Bashkir","башҡорт теле","ba","bak","bak"),
            new Language(false,"Basque","euskara, euskera","eu","eus","baq"),
            new Language(false,"Belarusian","беларуская мова","be","bel","bel"),
            new Language(false,"Bengali, Bangla","বাংলা","bn","ben","ben"),
            new Language(false,"Bihari","भोजपुरी","bh","bih","bih"),
            new Language(false,"Bislama","Bislama","bi","bis","bis"),
            new Language(false,"Bosnian","bosanski jezik","bs","bos","bos"),
            new Language(false,"Breton","brezhoneg","br","bre","bre"),
            new Language(false,"Bulgarian","български език","bg","bul","bul"),
            new Language(false,"Burmese","ဗမာစာ","my","mya","bur"),
            new Language(false,"Catalan","català","ca","cat","cat"),
            new Language(false,"Chamorro","Chamoru","ch","cha","cha"),
            new Language(false,"Chechen","нохчийн мотт","ce","che","che"),
            new Language(false,"Chichewa, Chewa, Nyanja","chiCheŵa, chinyanja","ny","nya","nya"),
            new Language(false,"Chinese","中文 (Zhōngwén), 汉语, 漢語","zh","zho","chi"),
            new Language(false,"Chuvash","чӑваш чӗлхи","cv","chv","chv"),
            new Language(false,"Cornish","Kernewek","kw","cor","cor"),
            new Language(false,"Corsican","corsu, lingua corsa","co","cos","cos"),
            new Language(false,"Cree","ᓀᐦᐃᔭᐍᐏᐣ","cr","cre","cre"),
            new Language(false,"Croatian","hrvatski jezik","hr","hrv","hrv"),
            new Language(false,"Czech","čeština, český jazyk","cs","ces","cze"),
            new Language(false,"Danish","dansk","da","dan","dan"),
            new Language(false,"Divehi, Dhivehi, Maldivian","ދިވެހި","dv","div","div"),
            new Language(false,"Dutch","Nederlands, Vlaams","nl","nld","dut"),
            new Language(false,"Dzongkha","རྫོང་ཁ","dz","dzo","dzo"),
            new Language(true,"English","English","en","eng","eng"),
            new Language(false,"Esperanto","Esperanto","eo","epo","epo"),
            new Language(false,"Estonian","eesti, eesti keel","et","est","est"),
            new Language(false,"Ewe","Eʋegbe","ee","ewe","ewe"),
            new Language(false,"Faroese","føroyskt","fo","fao","fao"),
            new Language(false,"Fijian","vosa Vakaviti","fj","fij","fij"),
            new Language(false,"Finnish","suomi, suomen kieli","fi","fin","fin"),
            new Language(false,"French","français, langue française","fr","fra","fre"),
            new Language(false,"Fula, Fulah, Pulaar, Pular","Fulfulde, Pulaar, Pular","ff","ful","ful"),
            new Language(false,"Galician","galego","gl","glg","glg"),
            new Language(false,"Georgian","ქართული","ka","kat","geo"),
            new Language(true,"German","Deutsch","de","deu","ger"),
            new Language(false,"Greek (modern)","ελληνικά","el","ell","gre"),
            new Language(false,"Guaraní","Avañe'ẽ","gn","grn","grn"),
            new Language(false,"Gujarati","ગુજરાતી","gu","guj","guj"),
            new Language(false,"Haitian, Haitian Creole","Kreyòl ayisyen","ht","hat","hat"),
            new Language(false,"Hausa","(Hausa) هَوُسَ","ha","hau","hau"),
            new Language(false,"Hebrew (modern)","עברית","he","heb","heb"),
            new Language(false,"Herero","Otjiherero","hz","her","her"),
            new Language(false,"Hindi","हिन्दी, हिंदी","hi","hin","hin"),
            new Language(false,"Hiri Motu","Hiri Motu","ho","hmo","hmo"),
            new Language(false,"Hungarian","magyar","hu","hun","hun"),
            new Language(false,"Interlingua","Interlingua","ia","ina","ina"),
            new Language(false,"Indonesian","Bahasa Indonesia","id","ind","ind"),
            new Language(false,"Interlingue","Originally called Occidental then Interlingue after WWII","ie","ile","ile"),
            new Language(false,"Irish","Gaeilge","ga","gle","gle"),
            new Language(false,"Igbo","Asụsụ Igbo","ig","ibo","ibo"),
            new Language(false,"Inupiaq","Iñupiaq, Iñupiatun","ik","ipk","ipk"),
            new Language(false,"Ido","Ido","io","ido","ido"),
            new Language(false,"Icelandic","Íslenska","is","isl","ice"),
            new Language(false,"Italian","italiano","it","ita","ita"),
            new Language(false,"Inuktitut","ᐃᓄᒃᑎᑐᑦ","iu","iku","iku"),
            new Language(false,"Japanese","日本語 (にほんご)","ja","jpn","jpn"),
            new Language(false,"Javanese","ꦧꦱꦗꦮ, Basa Jawa","jv","jav","jav"),
            new Language(false,"Kalaallisut, Greenlandic","kalaallisut, kalaallit oqaasii","kl","kal","kal"),
            new Language(false,"Kannada","ಕನ್ನಡ","kn","kan","kan"),
            new Language(false,"Kanuri","Kanuri","kr","kau","kau"),
            new Language(false,"Kashmiri","कश्मीरी, كشميري‎","ks","kas","kas"),
            new Language(false,"Kazakh","қазақ тілі","kk","kaz","kaz"),
            new Language(false,"Khmer","ខ្មែរ, ខេមរភាសា, ភាសាខ្មែរ","km","khm","khm"),
            new Language(false,"Kikuyu, Gikuyu","Gĩkũyũ","ki","kik","kik"),
            new Language(false,"Kinyarwanda","Ikinyarwanda","rw","kin","kin"),
            new Language(false,"Kyrgyz","Кыргызча, Кыргыз тили","ky","kir","kir"),
            new Language(false,"Komi","коми кыв","kv","kom","kom"),
            new Language(false,"Kongo","Kikongo","kg","kon","kon"),
            new Language(false,"Korean","한국어","ko","kor","kor"),
            new Language(false,"Kurdish","Kurdî, كوردی‎","ku","kur","kur"),
            new Language(false,"Kwanyama, Kuanyama","Kuanyama","kj","kua","kua"),
            new Language(false,"Latin","latine, lingua latina","la","lat","lat"),
            new Language(false,"Luxembourgish, Letzeburgesch","Lëtzebuergesch","lb","ltz","ltz"),
            new Language(false,"Ganda","Luganda","lg","lug","lug"),
            new Language(false,"Limburgish, Limburgan, Limburger","Limburgs","li","lim","lim"),
            new Language(false,"Lingala","Lingála","ln","lin","lin"),
            new Language(false,"Lao","ພາສາລາວ","lo","lao","lao"),
            new Language(false,"Lithuanian","lietuvių kalba","lt","lit","lit"),
            new Language(false,"Luba-Katanga","Tshiluba","lu","lub","lub"),
            new Language(false,"Latvian","latviešu valoda","lv","lav","lav"),
            new Language(false,"Manx","Gaelg, Gailck","gv","glv","glv"),
            new Language(false,"Macedonian","македонски јазик","mk","mkd","mac"),
            new Language(false,"Malagasy","fiteny malagasy","mg","mlg","mlg"),
            new Language(false,"Malay","bahasa Melayu, بهاس ملايو‎","ms","msa","may"),
            new Language(false,"Malayalam","മലയാളം","ml","mal","mal"),
            new Language(false,"Maltese","Malti","mt","mlt","mlt"),
            new Language(false,"Māori","te reo Māori","mi","mri","mao"),
            new Language(false,"Marathi (Marāṭhī)","मराठी","mr","mar","mar"),
            new Language(false,"Marshallese","Kajin M̧ajeļ","mh","mah","mah"),
            new Language(false,"Mongolian","Монгол хэл","mn","mon","mon"),
            new Language(false,"Nauruan","Dorerin Naoero","na","nau","nau"),
            new Language(false,"Navajo, Navaho","Diné bizaad","nv","nav","nav"),
            new Language(false,"Northern Ndebele","isiNdebele","nd","nde","nde"),
            new Language(false,"Nepali","नेपाली","ne","nep","nep"),
            new Language(false,"Ndonga","Owambo","ng","ndo","ndo"),
            new Language(false,"Norwegian Bokmål","Norsk bokmål","nb","nob","nob"),
            new Language(false,"Norwegian Nynorsk","Norsk nynorsk","nn","nno","nno"),
            new Language(false,"Norwegian","Norsk","no","nor","nor"),
            new Language(false,"Nuosu","ꆈꌠ꒿ Nuosuhxop","ii","iii","iii"),
            new Language(false,"Southern Ndebele","isiNdebele","nr","nbl","nbl"),
            new Language(false,"Occitan","occitan, lenga d'òc","oc","oci","oci"),
            new Language(false,"Ojibwe, Ojibwa","ᐊᓂᔑᓈᐯᒧᐎᓐ","oj","oji","oji"),
            new Language(false,"Old Church Slavonic, Church Slavonic, Old Bulgarian","ѩзыкъ словѣньскъ","cu","chu","chu"),
            new Language(false,"Oromo","Afaan Oromoo","om","orm","orm"),
            new Language(false,"Oriya","ଓଡ଼ିଆ","or","ori","ori"),
            new Language(false,"Ossetian, Ossetic","ирон æвзаг","os","oss","oss"),
            new Language(false,"Eastern Punjabi, Eastern Panjabi","ਪੰਜਾਬੀ","pa","pan","pan"),
            new Language(false,"Pāli","पाऴि","pi","pli","pli"),
            new Language(false,"Persian (Farsi)","فارسی","fa","fas","per"),
            new Language(false,"Polish","język polski, polszczyzna","pl","pol","pol"),
            new Language(false,"Pashto, Pushto","پښتو","ps","pus","pus"),
            new Language(false,"Portuguese","Português","pt","por","por"),
            new Language(false,"Quechua","Runa Simi, Kichwa","qu","que","que"),
            new Language(false,"Romansh","rumantsch grischun","rm","roh","roh"),
            new Language(false,"Kirundi","Ikirundi","rn","run","run"),
            new Language(false,"Romanian","Română","ro","ron","rum"),
            new Language(false,"Russian","Русский","ru","rus","rus"),
            new Language(false,"Sanskrit (Saṁskṛta)","संस्कृतम्","sa","san","san"),
            new Language(false,"Sardinian","sardu","sc","srd","srd"),
            new Language(false,"Sindhi","सिन्धी, سنڌي، سندھی‎","sd","snd","snd"),
            new Language(false,"Northern Sami","Davvisámegiella","se","sme","sme"),
            new Language(false,"Samoan","gagana fa'a Samoa","sm","smo","smo"),
            new Language(false,"Sango","yângâ tî sängö","sg","sag","sag"),
            new Language(false,"Serbian","српски језик","sr","srp","srp"),
            new Language(false,"Scottish Gaelic, Gaelic","Gàidhlig","gd","gla","gla"),
            new Language(false,"Shona","chiShona","sn","sna","sna"),
            new Language(false,"Sinhalese, Sinhala","සිංහල","si","sin","sin"),
            new Language(false,"Slovak","slovenčina, slovenský jazyk","sk","slk","slo"),
            new Language(false,"Slovene","slovenski jezik, slovenščina","sl","slv","slv"),
            new Language(false,"Somali","Soomaaliga, af Soomaali","so","som","som"),
            new Language(false,"Southern Sotho","Sesotho","st","sot","sot"),
            new Language(false,"Spanish","español","es","spa","spa"),
            new Language(false,"Sundanese","Basa Sunda","su","sun","sun"),
            new Language(false,"Swahili","Kiswahili","sw","swa","swa"),
            new Language(false,"Swati","SiSwati","ss","ssw","ssw"),
            new Language(false,"Swedish","svenska","sv","swe","swe"),
            new Language(false,"Tamil","தமிழ்","ta","tam","tam"),
            new Language(false,"Telugu","తెలుగు","te","tel","tel"),
            new Language(false,"Tajik","тоҷикӣ, toçikī, تاجیکی‎","tg","tgk","tgk"),
            new Language(false,"Thai","ไทย","th","tha","tha"),
            new Language(false,"Tigrinya","ትግርኛ","ti","tir","tir"),
            new Language(false,"Tibetan Standard, Tibetan, Central","བོད་ཡིག","bo","bod","tib"),
            new Language(false,"Turkmen","Türkmen, Түркмен","tk","tuk","tuk"),
            new Language(false,"Tagalog","Wikang Tagalog","tl","tgl","tgl"),
            new Language(false,"Tswana","Setswana","tn","tsn","tsn"),
            new Language(false,"Tonga (Tonga Islands)","faka Tonga","to","ton","ton"),
            new Language(false,"Turkish","Türkçe","tr","tur","tur"),
            new Language(false,"Tsonga","Xitsonga","ts","tso","tso"),
            new Language(false,"Tatar","татар теле, tatar tele","tt","tat","tat"),
            new Language(false,"Twi","Twi","tw","twi","twi"),
            new Language(false,"Tahitian","Reo Tahiti","ty","tah","tah"),
            new Language(false,"Uyghur","ئۇيغۇرچە‎, Uyghurche","ug","uig","uig"),
            new Language(false,"Ukrainian","Українська","uk","ukr","ukr"),
            new Language(false,"Urdu","اردو","ur","urd","urd"),
            new Language(false,"Uzbek","Oʻzbek, Ўзбек, أۇزبېك‎","uz","uzb","uzb"),
            new Language(false,"Venda","Tshivenḓa","ve","ven","ven"),
            new Language(false,"Vietnamese","Tiếng Việt","vi","vie","vie"),
            new Language(false,"Volapük","Volapük","vo","vol","vol"),
            new Language(false,"Walloon","walon","wa","wln","wln"),
            new Language(false,"Welsh","Cymraeg","cy","cym","wel"),
            new Language(false,"Wolof","Wollof","wo","wol","wol"),
            new Language(false,"Western Frisian","Frysk","fy","fry","fry"),
            new Language(false,"Xhosa","isiXhosa","xh","xho","xho"),
            new Language(false,"Yiddish","ייִדיש","yi","yid","yid"),
            new Language(false,"Yoruba","Yorùbá","yo","yor","yor"),
            new Language(false,"Zhuang, Chuang","Saɯ cueŋƅ, Saw cuengh","za","zha","zha"),
            new Language(false,"Zulu","isiZulu","zu","zul","zul")
        }.OrderBy(language => language.Name);
    }

    public class Language
    {
        public bool Supported { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string Iso639_1 { get; set; }
        public string Iso639_2T { get; set; }
        public string Iso639_2B { get; set; }

        public Language(bool supported, string name, string nativeName, string iso6391, string iso639_2T, string iso639_2B)
        {
            Supported = supported;
            Name = name;
            NativeName = nativeName;
            Iso639_1 = iso6391;
            Iso639_2T = iso639_2T;
            Iso639_2B = iso639_2B;
        }
    }
}
