﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Theory
{
    public class ScaleList
    {
        public List<Scale_CSV> scales = null;

        public Scale_CSV this[int index]
        {
            get
            {
                return this.scales[index];
            }
        }

        public int Length
        {
            get
            {
                return scales.Count;
            }
        }

        public ScaleList()
        {
            // https://allthescales.org/downloads.php
            string rawData = @"#n_notes, scale_no, mode_name, semitones
3,1,Minoric, 444
4,1,Thaptic, 4341
4,1,Lothic, 3414
4,1,Phratic, 4143
4,1,Aerathic, 1434
4,2,Epathic, 4323
4,2,Mynic, 3234
4,2,Rothic, 2343
4,2,Eporic, 3432
4,3,Zyphic, 4431
4,3,Epogic, 4314
4,3,Lanic, 3144
4,3,Pyrric, 1443
4,4,Aeoloric, 4413
4,4,Gonic, 4134
4,4,Dalic, 1344
4,4,Dygic, 3441
4,5,Daric, 4332
4,5,Lonic, 3324
4,5,Phradic, 3243
4,5,Bolic, 2433
4,6,Saric, 4233
4,6,Zoptic, 2334
4,6,Aeraphic, 3342
4,6,Byptic, 3423
4,7,Aeolic, 4422
4,7,Koptic, 4224
4,7,Mixolyric, 2244
4,7,Lydic, 2442
4,8,Stathic, 4242
4,8,Dadic, 2424
4,9,Phrynic, 3333
5,1,Epathitonic, 32322
5,1,Mynitonic, 23223
5,1,Rocritonic, 32232
5,1,Pentatonic, 22323
5,1,Thaptitonic, 23232
5,2,Magitonic, 43221
5,2,Daditonic, 32214
5,2,Aeolyphritonic, 22143
5,2,Gycritonic, 21432
5,2,Pyritonic, 14322
5,3,Gathitonic, 42321
5,3,Ionitonic, 23214
5,3,Phrynitonic, 32142
5,3,Stathitonic, 21423
5,3,Thalitonic, 14232
5,4,Zolitonic, 42141
5,4,Epogitonic, 21414
5,4,Lanitonic, 14142
5,4,Paptitonic, 41421
5,4,Ionacritonic, 14214
5,5,Phraditonic, 41412
5,5,Aeoloritonic, 14124
5,5,Gonitonic, 41241
5,5,Dalitonic, 12414
5,5,Dygitonic, 24141
5,6,Aeracritonic, 41232
5,6,Byptitonic, 12324
5,6,Daritonic, 23241
5,6,Lonitonic, 32412
5,6,Ionycritonic, 24123
5,7,Lothitonic, 41223
5,7,Phratonic, 12234
5,7,Aerathitonic, 22341
5,7,Saritonic, 23412
5,7,Zoptitonic, 34122
5,8,Dolitonic, 44121
5,8,Poritonic, 41214
5,8,Aerylitonic, 12144
5,8,Zagitonic, 21441
5,8,Lagitonic, 14412
5,9,Molitonic, 43311
5,9,Staptitonic, 33114
5,9,Mothitonic, 31143
5,9,Aeritonic, 11433
5,9,Ragitonic, 14331
5,10,Ionaditonic, 43212
5,10,Bocritonic, 32124
5,10,Gythitonic, 21243
5,10,Pagitonic, 12432
5,10,Aeolythitonic, 24321
5,11,Zacritonic, 43131
5,11,Laritonic, 31314
5,11,Thacritonic, 13143
5,11,Styditonic, 31431
5,11,Loritonic, 14313
5,12,Aeolyritonic, 43113
5,12,Goritonic, 31134
5,12,Aeoloditonic, 11343
5,12,Doptitonic, 13431
5,12,Aeraphitonic, 34311
5,13,Zathitonic, 42411
5,13,Raditonic, 24114
5,13,Stonitonic, 41142
5,13,Syptitonic, 11424
5,13,Ionythitonic, 14241
5,14,Aeolanitonic, 42231
5,14,Danitonic, 22314
5,14,Ionaritonic, 23142
5,14,Dynitonic, 31422
5,14,Zyditonic, 14223
5,15,Aeolacritonic, 42123
5,15,Zythitonic, 21234
5,15,Dyritonic, 12342
5,15,Koptitonic, 23421
5,15,Thocritonic, 34212
5,16,Lycritonic, 41331
5,16,Daptitonic, 13314
5,16,Kygitonic, 33141
5,16,Mocritonic, 31413
5,16,Zynitonic, 14133
5,17,Epygitonic, 41322
5,17,Zaptitonic, 13224
5,17,Kagitonic, 32241
5,17,Zogitonic, 22413
5,17,Epyritonic, 24132
5,18,Zothitonic, 41313
5,18,Phrolitonic, 13134
5,18,Ionagitonic, 31341
5,18,Aeolapritonic, 13413
5,18,Kyritonic, 34131
5,19,Ionyptitonic, 41133
5,19,Gyritonic, 11334
5,19,Zalitonic, 13341
5,19,Stolitonic, 33411
5,19,Bylitonic, 34113
5,20,Thoditonic, 33231
5,20,Dogitonic, 32313
5,20,Phralitonic, 23133
5,20,Garitonic, 31332
5,20,Soptitonic, 13323
5,21,Kataritonic, 33222
5,21,Sylitonic, 32223
5,21,Thonitonic, 22233
5,21,Phropitonic, 22332
5,21,Staditonic, 23322
5,22,Lyditonic, 33132
5,22,Mythitonic, 31323
5,22,Sogitonic, 13233
5,22,Gothitonic, 32331
5,22,Rothitonic, 23313
5,23,Zylitonic, 44211
5,23,Zoditonic, 42114
5,23,Zaritonic, 21144
5,23,Phrythitonic, 11442
5,23,Rolitonic, 14421
5,24,Ranitonic, 44112
5,24,Laditonic, 41124
5,24,Poditonic, 11244
5,24,Ionothitonic, 12441
5,24,Kanitonic, 24411
5,25,Ryphitonic, 43122
5,25,Gylitonic, 31224
5,25,Aeolycritonic, 12243
5,25,Pynitonic, 22431
5,25,Zanitonic, 24312
5,26,Phronitonic, 42312
5,26,Banitonic, 23124
5,26,Aeronitonic, 31242
5,26,Golitonic, 12423
5,26,Dyptitonic, 24231
5,27,Aerynitonic, 42213
5,27,Palitonic, 22134
5,27,Stothitonic, 21342
5,27,Aerophitonic, 13422
5,27,Katagitonic, 34221
5,28,Ionoditonic, 42132
5,28,Bogitonic, 21324
5,28,Mogitonic, 13242
5,28,Docritonic, 32421
5,28,Epaditonic, 24213
5,29,Mixitonic, 33321
5,29,Phrothitonic, 33213
5,29,Katycritonic, 32133
5,29,Ionalitonic, 21333
5,29,Loptitonic, 13332
5,30,Thyritonic, 33312
5,30,Thoptitonic, 33123
5,30,Bycritonic, 31233
5,30,Pathitonic, 12333
5,30,Myditonic, 23331
5,31,Bolitonic, 42222
5,31,Bothitonic, 22224
5,31,Kataditonic, 22242
5,31,Koditonic, 22422
5,31,Tholitonic, 24222
6,1,Epathimic, 322122
6,1,Mynimic, 221223
6,1,Rocrimic, 212232
6,1,Eporimic, 122322
6,1,Thaptimic, 223221
6,1,Lothimic, 232212
6,2,Dyrimic, 421221
6,2,Koptimic, 212214
6,2,Thocrimic, 122142
6,2,Aeolanimic, 221421
6,2,Danimic, 214212
6,2,Ionarimic, 142122
6,3,Daptimic, 414111
6,3,Kygimic, 141114
6,3,Mocrimic, 411141
6,3,Zynimic, 111414
6,3,Aeolimic, 114141
6,3,Zythimic, 141411
6,4,Epygimic, 412311
6,4,Zaptimic, 123114
6,4,Kagimic, 231141
6,4,Zogimic, 311412
6,4,Epyrimic, 114123
6,4,Lycrimic, 141231
6,5,Bylimic, 412221
6,5,Zothimic, 122214
6,5,Phrolimic, 222141
6,5,Ionagimic, 221412
6,5,Aeolaphimic, 214122
6,5,Kycrimic, 141222
6,6,Garimic, 412212
6,6,Soptimic, 122124
6,6,Ionyptimic, 221241
6,6,Gyrimic, 212412
6,6,Zalimic, 124122
6,6,Stolimic, 241221
6,7,Thonimic, 411411
6,7,Stadimic, 114114
6,7,Thodimic, 141141
6,8,Mythimic, 411321
6,8,Sogimic, 113214
6,8,Gogimic, 132141
6,8,Rothimic, 321411
6,8,Katarimic, 214113
6,8,Sylimic, 141132
6,9,Mixolimic, 323211
6,9,Dadimic, 232113
6,9,Aeolyphimic, 321132
6,9,Gycrimic, 211323
6,9,Pyrimic, 113232
6,9,Lydimic, 132321
6,10,Ionacrimic, 323112
6,10,Gathimic, 231123
6,10,Ionynimic, 311232
6,10,Phrynimic, 112323
6,10,Stathimic, 123231
6,10,Thatimic, 232311
6,11,Dalimic, 322311
6,11,Dygimic, 223113
6,11,Zolimic, 231132
6,11,Epogimic, 311322
6,11,Lanimic, 113223
6,11,Paptimic, 132231
6,12,Darmic, 322212
6,12,Lonimic, 222123
6,12,Ionycrimic, 221232
6,12,Phradimic, 212322
6,12,Aeolorimic, 123222
6,12,Gonimic, 232221
6,13,Phracrimic, 321222
6,13,Aerathimic, 212223
6,13,Sarimic, 122232
6,13,Zoptimic, 222321
6,13,Zeracrimic, 223212
6,13,Byptimic, 232122
6,14,Starimic, 432111
6,14,Phrathimic, 321114
6,14,Saptimic, 211143
6,14,Aerodimic, 111432
6,14,Macrimic, 114321
6,14,Rogimic, 143211
6,15,Bygimic, 431121
6,15,Thycrimic, 311214
6,15,Aeoladimic, 112143
6,15,Dylimic, 121431
6,15,Eponimic, 214311
6,15,Katygimic, 143112
6,16,Stalimic, 423111
6,16,Stoptimic, 231114
6,16,Zygimic, 311142
6,16,Kataptimic, 111423
6,16,Aeolaptimic, 114231
6,16,Pothimic, 142311
6,17,Rycrimic, 422121
6,17,Ronimic, 221214
6,17,Stycrimic, 212142
6,17,Katorimic, 121422
6,17,Epythimic, 214221
6,17,Kaptimic, 142212
6,18,Katythimic, 421311
6,18,Madimic, 213114
6,18,Aerygimic, 131142
6,18,Pylimic, 311421
6,18,Ionathimic, 114213
6,18,Morimic, 142131
6,19,Aerycrimic, 421131
6,19,Ganimic, 211314
6,19,Eparimic, 113142
6,19,Lyrimic, 131421
6,19,Phraptimic, 314211
6,19,Bacrimic, 142113
6,20,Phralimic, 413211
6,20,Phrogimic, 132114
6,20,Rathimic, 321141
6,20,Katocrimic, 211413
6,20,Phryptimic, 114132
6,20,Katynimic, 141321
6,21,Solimic, 413121
6,21,Ionolimic, 131214
6,21,Ionophimic, 312141
6,21,Aeologimic, 121413
6,21,Zadimic, 214131
6,21,Sygimic, 141312
6,22,Thogimic, 413112
6,22,Rythimic, 131124
6,22,Donimic, 311241
6,22,Aeoloptimic, 112413
6,22,Panimic, 124131
6,22,Lodimic, 241311
6,23,Laptimic, 412131
6,23,Lygimic, 121314
6,23,Logimic, 213141
6,23,Lalimic, 131412
6,23,Sothimic, 314121
6,23,Phrocrimic, 141213
6,24,Modimic, 412122
6,24,Barimic, 121224
6,24,Poptimic, 212241
6,24,Sagimic, 122412
6,24,Aelothimic, 224121
6,24,Socrimic, 241212
6,25,Syrimic, 412113
6,25,Stodimic, 121134
6,25,Ionocrimic, 211341
6,25,Zycrimic, 113412
6,25,Ionygimic, 134121
6,25,Katathimic, 341211
6,26,Bolimic, 411312
6,26,Bothimic, 113124
6,26,Katadimic, 131241
6,26,Kodimic, 312411
6,26,Tholimic, 124113
6,26,Ralimic, 241131
6,27,Kanimic, 411231
6,27,Zylimic, 112314
6,27,Zodimic, 123141
6,27,Zarimic, 231411
6,27,Phrythimic, 314112
6,27,Rorimic, 141123
6,28,Pynimic, 411132
6,28,Zanimic, 111324
6,28,Ranimic, 113241
6,28,Ladimic, 132411
6,28,Podimic, 324111
6,28,Ionothimic, 241113
6,29,Kytrimic, 411123
6,29,Golimic, 111234
6,29,Dyptimic, 112341
6,29,Ryrimic, 123411
6,29,Gylimic, 234111
6,29,Aeolycrimic, 341112
6,30,Palimic, 332211
6,30,Stothimic, 322113
6,30,Aeronimic, 221133
6,30,Katagimic, 211332
6,30,Phronimic, 113322
6,30,Banimic, 133221
6,31,Ionodimic, 331311
6,31,Bogimic, 313113
6,31,Mogimic, 131133
6,31,Docrimic, 311331
6,31,Epadimic, 113313
6,31,Aerynimic, 133131
6,32,Mydimic, 331131
6,32,Thyptimic, 311313
6,32,Phrothimic, 113133
6,32,Katycrimic, 131331
6,32,Ionalimic, 313311
6,32,Loptimic, 133113
6,33,Zagimic, 331122
6,33,Lagimic, 311223
6,33,Thyrimic, 112233
6,33,Thothimic, 122331
6,33,Bycrimic, 223311
6,33,Pathimic, 233112
6,34,Mothimic, 322131
6,34,Aeranimic, 221313
6,34,Ragimic, 213132
6,34,Dolimic, 131322
6,34,Porimic, 313221
6,34,Aerylimic, 132213
6,35,Bocrimic, 321312
6,35,Gythimic, 213123
6,35,Pagimic, 131232
6,35,Aeolythimic, 312321
6,35,Molimic, 123213
6,35,Staptimic, 232131
6,36,Zacrimic, 321231
6,36,Larimic, 212313
6,36,Thacrimic, 123132
6,36,Stydimic, 231321
6,36,Lorimic, 313212
6,36,Ionadimic, 132123
6,37,Ionythimic, 313131
6,37,Aerythimic, 131313
6,38,Dynimic, 313122
6,38,Zydimic, 131223
6,38,Zathimic, 312231
6,38,Radimic, 122313
6,38,Stonimic, 223131
6,38,Syptimic, 231312
6,39,Ponimic, 441111
6,39,Kadimic, 411114
6,39,Gynimic, 111144
6,39,Thydimic, 111441
6,39,Polimic, 114411
6,39,Thanimic, 144111
6,40,Lathimic, 431211
6,40,Aeralimic, 312114
6,40,Kynimic, 121143
6,40,Stynimic, 211431
6,40,Epytimic, 114312
6,40,Katoptimic, 143121
6,41,Galimic, 431112
6,41,Kathimic, 311124
6,41,Lylimic, 111243
6,41,Epalimic, 112431
6,41,Epacrimic, 124311
6,41,Sathimic, 243111
6,42,Katanimic, 422211
6,42,Katyrimic, 222114
6,42,Rynimic, 221142
6,42,Pogimic, 211422
6,42,Aeraptimic, 114222
6,42,Epylimic, 142221
6,43,Manimic, 421212
6,43,Marimic, 212124
6,43,Locrimic, 121242
6,43,Rylimic, 212421
6,43,Epatimic, 124212
6,43,Byrimic, 242121
6,44,Kocrimic, 421113
6,44,Korimic, 211134
6,44,Lynimic, 111342
6,44,Malimic, 113421
6,44,Synimic, 134211
6,44,Phragimic, 342111
6,45,Mycrimic, 411222
6,45,Ionorimic, 112224
6,45,Phrydimic, 122241
6,45,Zyptimic, 222411
6,45,Katothimic, 224112
6,45,Phrylimic, 241122
6,46,Aerothimic, 411213
6,46,Stagimic, 112134
6,46,Dorimic, 121341
6,46,Phrycrimic, 213411
6,46,Kyptimic, 134112
6,46,Ionylimic, 341121
6,47,Epynimic, 333111
6,47,Ionogimic, 331113
6,47,Kydimic, 311133
6,47,Gaptimic, 111333
6,47,Tharimic, 113331
6,47,Ionaphimic, 133311
6,48,Thoptimic, 332121
6,48,Bagimic, 321213
6,48,Kyrimic, 212133
6,48,Sonimic, 121332
6,48,Aeolonimic, 213321
6,48,Rygimic, 133212
6,49,Thagimic, 332112
6,49,Kolimic, 321123
6,49,Dycrimic, 211233
6,49,Epycrimic, 112332
6,49,Gocrimic, 123321
6,49,Katolimic, 233211
6,50,Dagimic, 331221
6,50,Aeolydimic, 312213
6,50,Parimic, 122133
6,50,Ionaptimic, 221331
6,50,Thylimic, 213312
6,50,Lolimic, 133122
6,51,Thalimic, 331212
6,51,Stygimic, 312123
6,51,Aeolygimic, 121233
6,51,Aerogimic, 212331
6,51,Dacrimic, 123312
6,51,Baptimic, 233121
6,52,Stythimic, 323121
6,52,Kothimic, 231213
6,52,Pygimic, 312132
6,52,Rodimic, 121323
6,52,Sorimic, 213231
6,52,Monimic, 132312
6,53,Aeragimic, 322221
6,53,Epothimic, 222213
6,53,Salimic, 222132
6,53,Lyptimic, 221322
6,53,Katonimic, 213222
6,53,Gygimic, 132222
6,54,Aeradimic, 321321
6,54,Zyrimic, 213213
6,54,Stylimic, 132132
6,55,Lythimic, 312312
6,55,Dodimic, 123123
6,55,Katalimic, 231231
6,56,Boptimic, 312222
6,56,Stogimic, 122223
6,56,Thynimic, 222231
6,56,Aeolathimic, 222312
6,56,Bythimic, 223122
6,56,Padimic, 231222
6,57,Dathimic, 422112
6,57,Epagimic, 221124
6,57,Raptimic, 211242
6,57,Epolimic, 112422
6,57,Sythimic, 124221
6,57,Sydimic, 242211
6,58,Gacrimic, 421122
6,58,Borimic, 211224
6,58,Sycrimic, 112242
6,58,Gadimic, 122421
6,58,Aeolocrimic, 224211
6,58,Phrygimic, 242112
6,59,WholeTone, 222222
7,1,Lydian, 2221221
7,1,Mixolydian, 2212212
7,1,Aeolian, 2122122
7,1,Locrian, 1221222
7,1,Ionian, 2212221
7,1,Dorian, 2122212
7,1,Phrygian, 1222122
7,2,Ionythian, 4122111
7,2,Aeolyrian, 1221114
7,2,Gorian, 2211141
7,2,Aeolodian, 2111412
7,2,Doptian, 1114122
7,2,Aeraphian, 1141221
7,2,Zacrian, 1412211
7,3,Ionarian, 4113111
7,3,Dynian, 1131114
7,3,Zydian, 1311141
7,3,Zathian, 3111411
7,3,Radian, 1114113
7,3,Stonian, 1141131
7,3,Syptian, 1411311
7,4,Aeolacrian, 4111311
7,4,Zythian, 1113114
7,4,Dyrian, 1131141
7,4,Koptian, 1311411
7,4,Thocrian, 3114111
7,4,Aeolanian, 1141113
7,4,Danian, 1411131
7,5,Zogian, 4111221
7,5,Epyrian, 1112214
7,5,Lycrian, 1122141
7,5,Daptian, 1221411
7,5,Kygian, 2214111
7,5,Mocrian, 2141112
7,5,Zynian, 1411122
7,6,Phrolian, 3221211
7,6,Ionagian, 2212113
7,6,Aeodian, 2121132
7,6,Kycrian, 1211322
7,6,Epygian, 2113221
7,6,Zaptian, 1132212
7,6,Kagian, 1322121
7,7,Soptian, 3221112
7,7,Ionyptian, 2211123
7,7,Gyrian, 2111232
7,7,Zalian, 1112322
7,7,Stolian, 1123221
7,7,Bylian, 1232211
7,7,Zothian, 2322111
7,8,Thonian, 3212211
7,8,Phrorian, 2122113
7,8,Stadian, 1221132
7,8,Thodian, 2211321
7,8,Dogian, 2113212
7,8,Mixopyrian, 1132122
7,8,Garian, 1321221
7,9,Epathian, 3211311
7,9,Mythian, 2113113
7,9,Sogian, 1131132
7,9,Gogian, 1311321
7,9,Rothian, 3113211
7,9,Katarian, 1132113
7,9,Stylian, 1321131
7,10,Stathian, 3211122
7,10,Mixonyphian, 2111223
7,10,Magian, 1112232
7,10,Dadian, 1122321
7,10,Aeolylian, 1223211
7,10,Gycrian, 2232111
7,10,Pyrian, 2321112
7,11,Epogian, 3113112
7,11,Lanian, 1131123
7,11,Paptian, 1311231
7,11,Ionacrian, 3112311
7,11,Gathian, 1123113
7,11,Ionyphian, 1231131
7,11,Phrynian, 2311311
7,12,Ionycrian, 3112212
7,12,Phradian, 1122123
7,12,Aeolorian, 1221231
7,12,Gonian, 2212311
7,12,Dalian, 2123112
7,12,Dygian, 1231122
7,12,Zolian, 2311221
7,13,Aerathian, 3112122
7,13,Sarian, 1121223
7,13,Zoptian, 1212231
7,13,Aeracrian, 2122311
7,13,Byptian, 1223112
7,13,Darian, 2231121
7,13,Lonian, 2311212
7,14,Aeopian, 4212111
7,14,Rygian, 2121114
7,14,Epynian, 1211142
7,14,Ionogian, 2111421
7,14,Kydian, 1114212
7,14,Gaptian, 1142121
7,14,Tharian, 1421211
7,15,Epycrian, 4211121
7,15,Gocrian, 2111214
7,15,Katolian, 1112142
7,15,Thoptian, 1121421
7,15,Bagian, 1214211
7,15,Kyrian, 2142111
7,15,Sonian, 1421112
7,16,Parian, 4131111
7,16,Ionaptian, 1311114
7,16,Thylian, 3111141
7,16,Lolian, 1111413
7,16,Thagian, 1114131
7,16,Kolian, 1141311
7,16,Dycrian, 1413111
7,17,Stygian, 4121211
7,17,Aeolygian, 1212114
7,17,Aerogian, 2121141
7,17,Dacrian, 1211412
7,17,Baptian, 2114121
7,17,Dagian, 1141212
7,17,Aeolydian, 1412121
7,18,Stythian, 4121121
7,18,Kothian, 1211214
7,18,Pygian, 2112141
7,18,Rodian, 1121412
7,18,Sorian, 1214121
7,18,Monian, 2141211
7,18,Thalian, 1412112
7,19,Zorian, 4121112
7,19,Aeragian, 1211124
7,19,Epothian, 2111241
7,19,Salian, 1112412
7,19,Lyptian, 1124121
7,19,Katonian, 1241211
7,19,Gyphian, 2412111
7,20,Thacrian, 4112211
7,20,Dodian, 1122114
7,20,Aeolyptian, 1221141
7,20,Aeolonian, 2211411
7,20,Aeradian, 2114112
7,20,Aeolagian, 1141122
7,20,Zyrian, 1411221
7,21,Aeolathian, 4112121
7,21,Bythian, 1121214
7,21,Padian, 1212141
7,21,Rolian, 2121411
7,21,Pydian, 1214112
7,21,Thygian, 2141121
7,21,Katalian, 1411212
7,22,Saptian, 4111212
7,22,Aerodian, 1112124
7,22,Macrian, 1121241
7,22,Rogian, 1212411
7,22,Boptian, 2124111
7,22,Stogian, 1241112
7,22,Thynian, 2411121
7,23,Thycrian, 4111131
7,23,Aeoladian, 1111314
7,23,Dylian, 1113141
7,23,Eponian, 1131411
7,23,Katygian, 1314111
7,23,Starian, 3141111
7,23,Phrathian, 1411113
7,24,Stalian, 3311211
7,24,Stoptian, 3112113
7,24,Zygian, 1121133
7,24,Kataptian, 1211331
7,24,Aeolaptian, 2113311
7,24,Pothian, 1133112
7,24,Bygian, 1331121
7,25,Morian, 3231111
7,25,Rycrian, 2311113
7,25,Ronian, 3111132
7,25,Stycrian, 1111323
7,25,Katorian, 1113231
7,25,Epythian, 1132311
7,25,Kaptian, 1323111
7,26,Phraptian, 3222111
7,26,Bacrian, 2221113
7,26,Katythian, 2211132
7,26,Madian, 2111322
7,26,Aerygian, 1113222
7,26,Pylian, 1132221
7,26,Ionathian, 1322211
7,27,Katocrian, 3213111
7,27,Phryptian, 2131113
7,27,Katynian, 1311132
7,27,Aerycrian, 3111321
7,27,Ganian, 1113213
7,27,Eparian, 1132131
7,27,Lyrian, 1321311
7,28,Ionopian, 3212112
7,28,Aeologian, 2121123
7,28,Zadian, 1211232
7,28,Sygian, 2112321
7,28,Phralian, 1123212
7,28,Phrogian, 1232121
7,28,Rathian, 2321211
7,29,Rythian, 3211212
7,29,Donian, 2112123
7,29,Aeoloptian, 1121232
7,29,Panian, 1212321
7,29,Lodian, 2123211
7,29,Solian, 1232112
7,29,Ionolian, 2321121
7,30,Laptian, 3211131
7,30,Lygian, 2111313
7,30,Logian, 1113132
7,30,Lalian, 1131321
7,30,Sothian, 1313211
7,30,Phrocrian, 3132111
7,30,Thogian, 1321113
7,31,Katathian, 3131211
7,31,Modian, 1312113
7,31,Barian, 3121131
7,31,Mixolocrian, 1211313
7,31,Sagian, 2113131
7,31,Aeolothian, 1131312
7,31,Socrian, 1313121
7,32,Tholian, 3131121
7,32,Ralian, 1311213
7,32,Syrian, 3112131
7,32,Stodian, 1121313
7,32,Ionocrian, 1213131
7,32,Zycrian, 2131311
7,32,Ionygian, 1313112
7,33,Zarian, 3131112
7,33,Phrythian, 1311123
7,33,Rorian, 3111231
7,33,Bolian, 1112313
7,33,Bothian, 1123131
7,33,Katadian, 1231311
7,33,Kodian, 2313111
7,34,Ranian, 3123111
7,34,Ladian, 1231113
7,34,Podian, 2311131
7,34,Ionothian, 3111312
7,34,Kanian, 1113123
7,34,Zylian, 1131231
7,34,Zodian, 1312311
7,35,Golian, 3122211
7,35,Dyptian, 1222113
7,35,Ryphian, 2221131
7,35,Gylian, 2211312
7,35,Aeolycrian, 2113122
7,35,Pynian, 1131222
7,35,Zanian, 1312221
7,36,Palian, 3122121
7,36,Stothian, 1221213
7,36,Aerorian, 2212131
7,36,Katagian, 2121312
7,36,Phronian, 1213122
7,36,Banian, 2131221
7,36,Aeronian, 1312212
7,37,Loptian, 3121311
7,37,Ionodian, 1213113
7,37,Bogian, 2131131
7,37,Mogian, 1311312
7,37,Docrian, 3113121
7,37,Epadian, 1131213
7,37,Aerynian, 1312131
7,38,Bycrian, 3121221
7,38,Pathian, 1212213
7,38,Mydian, 2122131
7,38,Thyptian, 1221312
7,38,Phrothian, 2213121
7,38,Katycrian, 2131212
7,38,Ionalian, 1312122
7,39,Dolian, 3112221
7,39,Porian, 1122213
7,39,Aerylian, 1222131
7,39,Zagian, 2221311
7,39,Lagian, 2213112
7,39,Tyrian, 2131122
7,39,Mixonorian, 1311222
7,40,Pagian, 3111222
7,40,Aeolythian, 1112223
7,40,Molian, 1122231
7,40,Staptian, 1222311
7,40,Mothian, 2223111
7,40,Aeranian, 2231112
7,40,Ragian, 2311122
7,41,Larian, 2222121
7,41,Lythian, 2221212
7,41,Stydian, 2212122
7,41,Lorian, 2121222
7,41,Ionadian, 1212222
7,41,Bocrian, 2122221
7,41,Mixolythian, 1222212
7,42,Thadian, 4311111
7,42,Sanian, 3111114
7,42,Ionydian, 1111143
7,42,Epydian, 1111431
7,42,Katydian, 1114311
7,42,Mathian, 1143111
7,42,Aeryptian, 1431111
7,43,Pythian, 4221111
7,43,Katylian, 2211114
7,43,Bydian, 2111142
7,43,Bynian, 1111422
7,43,Galian, 1114221
7,43,Zonian, 1142211
7,43,Myrian, 1422111
7,44,Katogian, 4211211
7,44,Stacrian, 2112114
7,44,Styrian, 1121142
7,44,Ionyrian, 1211421
7,44,Phrodian, 2114211
7,44,Pycrian, 1142112
7,44,Gyptian, 1421121
7,45,Katacrian, 4112112
7,45,Sodian, 1121124
7,45,Bathian, 1211241
7,45,Mylian, 2112411
7,45,Godian, 1124112
7,45,Thorian, 1241121
7,45,Zocrian, 2411211
7,46,Stanian, 4111122
7,46,Epanian, 1111224
7,46,Konian, 1112241
7,46,Stocrian, 1122411
7,46,Kalian, 1224111
7,46,Phroptian, 2241111
7,46,Dydian, 2411112
7,47,Katyptian, 4111113
7,47,Epodian, 1111134
7,47,Mygian, 1111341
7,47,Pacrian, 1113411
7,47,Aerocrian, 1134111
7,47,Aeolarian, 1341111
7,47,Kythian, 3411111
7,48,Bonian, 3321111
7,48,Badian, 3211113
7,48,Katodian, 2111133
7,48,Sadian, 1111332
7,48,Dothian, 1113321
7,48,Moptian, 1133211
7,48,Aeryrian, 1332111
7,49,Epagian, 3312111
7,49,Raptian, 3121113
7,49,Epolian, 1211133
7,49,Sythian, 2111331
7,49,Sydian, 1113312
7,49,Epocrian, 1133121
7,49,Kylian, 1331211
7,50,Gacrian, 3311121
7,50,Borian, 3111213
7,50,Sycrian, 1112133
7,50,Gadian, 1121331
7,50,Aeolocrian, 1213311
7,50,Mixodorian, 2133111
7,50,Dathian, 1331112
7,51,Katoptian, 3311112
7,51,Ponian, 3111123
7,51,Kadian, 1111233
7,51,Gynian, 1112331
7,51,Thyphian, 1123311
7,51,Polian, 1233111
7,51,Thanian, 2331111
7,52,Epacrian, 3221121
7,52,Sathian, 2211213
7,52,Lathian, 2112132
7,52,Aeralian, 1121322
7,52,Kynian, 1213221
7,52,Stynian, 2132211
7,52,Epyphian, 1322112
7,53,Pogian, 3212121
7,53,Aeraptian, 2121213
7,53,Epylian, 1212132
7,53,Gamian, 2121321
7,53,Kathian, 1213212
7,53,Lylian, 2132121
7,53,Epalian, 1321212
7,54,Eporian, 3211221
7,54,Rylian, 2112213
7,54,Epaptian, 1122132
7,54,Byrian, 1221321
7,54,Katanian, 2213211
7,54,Katyrian, 2132112
7,54,Rynian, 1321122
7,55,Korian, 3122112
7,55,Lynian, 1221123
7,55,Malian, 2211231
7,55,Synian, 2112312
7,55,Phragian, 1123122
7,55,Manian, 1231221
7,55,Marian, 2312211
7,56,Mycrian, 3121212
7,56,Ionorian, 1212123
7,56,Phrydian, 2121231
7,56,Zyptian, 1212312
7,56,Katothian, 2123121
7,56,Phrylian, 1231212
7,56,Kocrian, 2312121
7,57,Ionanian, 3121122
7,57,Aerothian, 1211223
7,57,Stagian, 2112231
7,57,Lothian, 1122312
7,57,Phrycrian, 1223121
7,57,Kyptian, 2231211
7,57,Ionylian, 2312112
7,58,Gydian, 4211112
7,58,Kogian, 2111124
7,58,Rarian, 1111242
7,58,Aerolian, 1112421
7,58,Karian, 1124211
7,58,Myptian, 1242111
7,58,Rydian, 2421111
7,59,Aeolynian, 2222211
7,59,Aeroptian, 2222112
7,59,Phryrian, 2221122
7,59,Gothian, 2211222
7,59,Storian, 2112222
7,59,Pyptian, 1122222
7,59,Thydian, 1222221
8,1,Aerycryllic, 22122111
8,1,Gadyllic, 21221112
8,1,Solyllic, 12211122
8,1,Zylyllic, 22111221
8,1,Mixodyllic, 21112212
8,1,Soryllic, 11122122
8,1,Godyllic, 11221221
8,1,Epiphyllic, 12212211
8,2,Pynyllic, 41112111
8,2,Bocryllic, 11121114
8,2,Kogyllic, 11211141
8,2,Raryllic, 12111411
8,2,Zycryllic, 21114111
8,2,Mycryllic, 11141112
8,2,Laptyllic, 11411121
8,2,Pylyllic, 14111211
8,3,Pothyllic, 32111211
8,3,Phronyllic, 21112113
8,3,Stynyllic, 11121132
8,3,Rathyllic, 11211321
8,3,Aeryptyllic, 12113211
8,3,Zydyllic, 21132111
8,3,Katolyllic, 11321112
8,3,Rythyllic, 13211121
8,4,Locryllic, 31131111
8,4,Bylyllic, 11311113
8,4,Sogyllic, 13111131
8,4,Ionycryllic, 31111311
8,4,Koptyllic, 11113113
8,4,Epyryllic, 11131131
8,4,Soptyllic, 11311311
8,4,Aeolylyllic, 13113111
8,5,Aeracryllic, 31122111
8,5,Epygyllic, 11221113
8,5,Thonyllic, 12211131
8,5,Lanyllic, 22111311
8,5,Phrynyllic, 21113112
8,5,Lycryllic, 11131122
8,5,Ionyptyllic, 11311221
8,5,Epathyllic, 13112211
8,6,Dydyllic, 31121211
8,6,Thogyllic, 11212113
8,6,Rygyllic, 12121131
8,6,Bycryllic, 21211311
8,6,Zacryllic, 12113112
8,6,Panyllic, 21131121
8,6,Dyryllic, 11311212
8,6,Zathyllic, 13112121
8,7,Dagyllic, 31121112
8,7,Katalyllic, 11211123
8,7,Katoryllic, 12111231
8,7,Dodyllic, 21112311
8,7,Zogyllic, 11123112
8,7,Madyllic, 11231121
8,7,Dycryllic, 12311211
8,7,Aeologyllic, 23112111
8,8,Sydyllic, 31113111
8,8,Katogyllic, 11131113
8,8,Zygyllic, 11311131
8,8,Aeralyllic, 13111311
8,9,Bacryllic, 31112211
8,9,Aerygyllic, 11122113
8,9,Dathyllic, 11221131
8,9,Boptyllic, 12211311
8,9,Bagyllic, 22113111
8,9,Mathyllic, 21131112
8,9,Styptyllic, 11311122
8,9,Zolyllic, 13111221
8,10,Rocryllic, 22212111
8,10,Zyryllic, 22121112
8,10,Sagyllic, 21211122
8,10,Epinyllic, 12111222
8,10,Katagyllic, 21112221
8,10,Ragyllic, 11122212
8,10,Gothyllic, 11222121
8,10,Lythyllic, 12221211
8,11,Ionocryllic, 22211121
8,11,Gocryllic, 22111212
8,11,Epiryllic, 21112122
8,11,Aeradyllic, 11121222
8,11,Staptyllic, 11212221
8,11,Danyllic, 12122211
8,11,Goptyllic, 21222111
8,11,Epocryllic, 12221112
8,12,Ionoptyllic, 22121121
8,12,Aeoloryllic, 21211212
8,12,Thydyllic, 12112122
8,12,Gycryllic, 21121221
8,12,Lyryllic, 11212212
8,12,Mogyllic, 12122121
8,12,Katodyllic, 21221211
8,12,Moptyllic, 12212112
8,13,Dolyllic, 41211111
8,13,Moryllic, 12111114
8,13,Bydyllic, 21111141
8,13,Pocryllic, 11111412
8,13,Phracryllic, 11114121
8,13,Gyryllic, 11141211
8,13,Phrygyllic, 11412111
8,13,Dogyllic, 14121111
8,14,Thagyllic, 41121111
8,14,Thoptyllic, 11211114
8,14,Phraptyllic, 12111141
8,14,Gylyllic, 21111411
8,14,Phralyllic, 11114112
8,14,Dygyllic, 11141121
8,14,Ronyllic, 11411211
8,14,Epogyllic, 14112111
8,15,Aeoladyllic, 41111211
8,15,Kocryllic, 11112114
8,15,Lodyllic, 11121141
8,15,Bynyllic, 11211411
8,15,Kydyllic, 12114111
8,15,Bygyllic, 21141111
8,15,Phryptyllic, 11411112
8,15,Ionayllic, 14111121
8,16,Phroryllic, 41111121
8,16,Thyphyllic, 11111214
8,16,Poptyllic, 11112141
8,16,Mixonyllic, 11121411
8,16,Paptyllic, 11214111
8,16,Storyllic, 12141111
8,16,Phrycryllic, 21411111
8,16,Palyllic, 14111112
8,17,Phranyllic, 32211111
8,17,Stydyllic, 22111113
8,17,Zadyllic, 21111132
8,17,Zalyllic, 11111322
8,17,Zocryllic, 11113221
8,17,Katocryllic, 11132211
8,17,Aerathyllic, 11322111
8,17,Stoptyllic, 13221111
8,18,Lydyllic, 32121111
8,18,Radyllic, 21211113
8,18,Stagyllic, 12111132
8,18,Ionoryllic, 21111321
8,18,Phrodyllic, 11113212
8,18,Aeragyllic, 11132121
8,18,Banyllic, 11321211
8,18,Epothyllic, 13212111
8,19,Zoryllic, 32112111
8,19,Phrolyllic, 21121113
8,19,Kolyllic, 11211132
8,19,Thodyllic, 12111321
8,19,Socryllic, 21113211
8,19,Aeolyllic, 11132112
8,19,Zythyllic, 11321121
8,19,Aeoryllic, 13211211
8,20,Mixolydyllic, 32111112
8,20,Mixonyphyllic, 21111123
8,20,Aeolanyllic, 11111232
8,20,Thocryllic, 11112321
8,20,Kygyllic, 11123211
8,20,Ionagyllic, 11232111
8,20,Gogyllic, 12321111
8,20,Phradyllic, 23211111
8,21,Ioniptyllic, 31311111
8,21,Kycryllic, 13111113
8,21,Aeolaptyllic, 31111131
8,21,Rodyllic, 11111313
8,21,Ionathyllic, 11113131
8,21,Pythyllic, 11131311
8,21,Zonyllic, 11313111
8,21,Ryryllic, 13131111
8,22,Aeolothyllic, 31221111
8,22,Ionyryllic, 12211113
8,22,Rydyllic, 22111131
8,22,Gonyllic, 21111312
8,22,Rolyllic, 11113122
8,22,Katydyllic, 11131221
8,22,Zyptyllic, 11312211
8,22,Modyllic, 13122111
8,23,Maptyllic, 31212111
8,23,Aeraptyllic, 12121113
8,23,Katadyllic, 21211131
8,23,Magyllic, 12111312
8,23,Phrylyllic, 21113121
8,23,Epigyllic, 11131212
8,23,Molyllic, 11312121
8,23,Ponyllic, 13121211
8,24,Thyptyllic, 31211211
8,24,Ionogyllic, 12112113
8,24,Aeolaryllic, 21121131
8,24,Katygyllic, 11211312
8,24,Ganyllic, 12113121
8,24,Kyptyllic, 21131211
8,24,Salyllic, 11312112
8,24,Sanyllic, 13121121
8,25,Doptyllic, 31211121
8,25,Ionilyllic, 12111213
8,25,Manyllic, 21112131
8,25,Polyllic, 11121312
8,25,Stanyllic, 11213121
8,25,Mixotharyllic, 12131211
8,25,Eporyllic, 21312111
8,25,Aerynyllic, 13121112
8,26,Lonyllic, 31121121
8,26,Sathyllic, 11211213
8,26,Layllic, 12112131
8,26,Saryllic, 21121311
8,26,Thacryllic, 11213112
8,26,Aeolynyllic, 12131121
8,26,Thadyllic, 21311211
8,26,Lynyllic, 13112112
8,27,Aeolathyllic, 31112121
8,27,Aeolocryllic, 11121213
8,27,Phroptyllic, 11212131
8,27,Kodyllic, 12121311
8,27,Epaptyllic, 21213111
8,27,Ionoyllic, 12131112
8,27,Gyptyllic, 21311121
8,27,Aerythyllic, 13111212
8,28,Zagyllic, 31112112
8,28,Epacryllic, 11121123
8,28,Thorcryllic, 11211231
8,28,Loptyllic, 12112311
8,28,Katylyllic, 21123111
8,28,Malyllic, 11231112
8,28,Mydyllic, 12311121
8,28,Thycryllic, 23111211
8,29,Gythyllic, 31111221
8,29,Pyryllic, 11112213
8,29,Rycryllic, 11122131
8,29,Phrathyllic, 11221311
8,29,Badyllic, 12213111
8,29,Phrocryllic, 22131111
8,29,Staryllic, 21311112
8,29,Zothyllic, 13111122
8,30,Tharyllic, 31111212
8,30,Sylyllic, 11112123
8,30,Lothyllic, 11121231
8,30,Daryllic, 11212311
8,30,Monyllic, 12123111
8,30,Styryllic, 21231111
8,30,Aeolacryllic, 12311112
8,30,Raptyllic, 23111121
8,31,Kataryllic, 31111122
8,31,Aerocryllic, 11111223
8,31,Zanyllic, 11112231
8,31,Aeolonyllic, 11122311
8,31,Aeonyllic, 11223111
8,31,Kyryllic, 12231111
8,31,Sythyllic, 22311111
8,31,Katycryllic, 23111112
8,32,Stogyllic, 22121211
8,32,Ionidyllic, 21212112
8,32,Stonyllic, 12121122
8,32,Stalyllic, 21211221
8,32,Poryllic, 12112212
8,32,Mocryllic, 21122121
8,32,Aeolyryllic, 11221212
8,32,Baryllic, 12212121
8,33,Dalyllic, 22112121
8,33,Ionyphyllic, 21121212
8,33,Zaptyllic, 11212122
8,33,Garyllic, 12121221
8,33,Gathyllic, 21212211
8,33,Mixopyryllic, 12122112
8,33,Ionacryllic, 21221121
8,33,Stylyllic, 12211212
8,34,Stycryllic, 42111111
8,34,Ionothyllic, 21111114
8,34,Mythyllic, 11111142
8,34,Aerylyllic, 11111421
8,34,Bonyllic, 11114211
8,34,Tholyllic, 11142111
8,34,Katyryllic, 11421111
8,34,Sadyllic, 14211111
8,35,Stolyllic, 41111112
8,35,Logyllic, 11111124
8,35,Dacryllic, 11111241
8,35,Thynyllic, 11112411
8,35,Gydyllic, 11124111
8,35,Eparyllic, 11241111
8,35,Dynyllic, 12411111
8,35,Ionyllic, 24111111
8,36,Zaryllic, 33111111
8,36,Dythyllic, 31111113
8,36,Ionaryllic, 11111133
8,36,Laryllic, 11111331
8,36,Kataptyllic, 11113311
8,36,Sonyllic, 11133111
8,36,Pathyllic, 11331111
8,36,Loryllic, 13311111
8,37,Aeronyllic, 32111121
8,37,Pycryllic, 21111213
8,37,Mygyllic, 11112132
8,37,Lylyllic, 11121321
8,37,Daptyllic, 11213211
8,37,Ioninyllic, 12132111
8,37,Epaphyllic, 21321111
8,37,Lolyllic, 13211112
8,38,Stacryllic, 31211112
8,38,Doryllic, 12111123
8,38,Kadyllic, 21111231
8,38,Rynyllic, 11112312
8,38,Aerogyllic, 11123121
8,38,Rothyllic, 11231211
8,38,Kagyllic, 12312111
8,38,Stathyllic, 23121111
8,39,Thyryllic, 22221111
8,39,Gygyllic, 22211112
8,39,Sodyllic, 22111122
8,39,Goryllic, 21111222
8,39,Bothyllic, 11112222
8,39,Gynyllic, 11122221
8,39,Ionaptyllic, 11222211
8,39,Phryryllic, 12222111
8,40,Racryllic, 22211211
8,40,Epicryllic, 22112112
8,40,Stygyllic, 21121122
8,40,Syryllic, 11211222
8,40,Stythyllic, 12112221
8,40,Aerothyllic, 21122211
8,40,Mixoryllic, 11222112
8,40,Thanyllic, 12221121
8,41,Roryllic, 22112211
8,41,Epotyllic, 21122112
8,41,Epidyllic, 11221122
8,41,Kaptyllic, 12211221
8,42,MajorDimin., 21212121
8,42,MinorDimin., 12121212
9,1,Aerycrygic, 221112111
9,1,Gadygic, 211121112
9,1,Solygic, 111211122
9,1,Zylygic, 112111221
9,1,Garygic, 121112211
9,1,Sorygic, 211122111
9,1,Godygic, 111221112
9,1,Epithygic, 112211121
9,1,Ionoptygic, 122111211
9,2,Kalygic, 311211111
9,2,Ionodygic, 112111113
9,2,Bythygic, 121111131
9,2,Epygic, 211111311
9,2,Marygic, 111113112
9,2,Gaptygic, 111131121
9,2,Aeroptygic, 111311211
9,2,Mylygic, 113112111
9,2,Galygic, 131121111
9,3,Mixolydygic, 311121111
9,3,Ionycrygic, 111211113
9,3,Zoptygic, 112111131
9,3,Phrygygic, 121111311
9,3,Locrygic, 211113111
9,3,Gonygic, 111131112
9,3,Aeracrygic, 111311121
9,3,Aerathygic, 113111211
9,3,Dorygic, 131112111
9,4,Dycrygic, 311112111
9,4,Aeolygic, 111121113
9,4,Dydygic, 111211131
9,4,Tholygic, 112111311
9,4,Rynygic, 121113111
9,4,Bycrygic, 211131111
9,4,Zacrygic, 111311112
9,4,Panygic, 113111121
9,4,Dyrygic, 131111211
9,5,Loptygic, 311111211
9,5,Katylygic, 111112113
9,5,Phradygic, 111121131
9,5,Mixodygic, 111211311
9,5,Katalygic, 112113111
9,5,Katorygic, 121131111
9,5,Dogygic, 211311111
9,5,Zodygic, 113111112
9,5,Madygic, 131111121
9,6,Bagygic, 221211111
9,6,Mathygic, 212111112
9,6,Styptygic, 121111122
9,6,Zolygic, 211111221
9,6,Sydygic, 111112212
9,6,Katygic, 111122121
9,6,Zyphygic, 111221211
9,6,Aeralygic, 112212111
9,6,Ryptygic, 122121111
9,7,Apinygic, 221111121
9,7,Katagygic, 211111212
9,7,Radygic, 111112122
9,7,Gothygic, 111121221
9,7,Lythygic, 111212211
9,7,Bacrygic, 112122111
9,7,Aerygic, 121221111
9,7,Dathygic, 212211111
9,7,Boptygic, 122111112
9,8,Epyrygic, 212112111
9,8,Aeradygic, 121121112
9,8,Staptygic, 211211121
9,8,Danygic, 112111212
9,8,Goptygic, 121112121
9,8,Epocrygic, 211121211
9,8,Rocrygic, 111212112
9,8,Zyrygic, 112121121
9,8,Sadygic, 121211211
9,9,Aeolorygic, 212111211
9,9,Thydygic, 121112112
9,9,Gycrygic, 211121121
9,9,Lyrygic, 111211212
9,9,Modygic, 112112121
9,9,Katodygic, 121121211
9,9,Moptygic, 211212111
9,9,Ionocrygic, 112121112
9,9,Gocrygic, 121211121
9,10,Manygic, 411111111
9,10,Polygic, 111111114
9,10,Stanygic, 111111141
9,10,Thaptygic, 111111411
9,10,Eporygic, 111114111
9,10,Aerynygic, 111141111
9,10,Thyptygic, 111411111
9,10,Ionogygic, 114111111
9,10,Aeolarygic, 141111111
9,11,Sathygic, 321111111
9,11,Ladygic, 211111113
9,11,Sarygic, 111111132
9,11,Thacrygic, 111111321
9,11,Aeolynygic, 111113211
9,11,Thadygic, 111132111
9,11,Lynygic, 111321111
9,11,Doptygic, 113211111
9,11,Ionilygic, 132111111
9,12,Phrygic, 312111111
9,12,Aeranygic, 121111113
9,12,Dothygic, 211111131
9,12,Lydygic, 111111312
9,12,Stadygic, 111113121
9,12,Byptygic, 111131211
9,12,Stodygic, 111312111
9,12,Zynygic, 113121111
9,12,Lonygic, 131211111
9,13,Zothygic, 311111121
9,13,Aeolathygic, 111111213
9,13,Aeolocrygic, 111112131
9,13,Phroptygic, 111121311
9,13,Kodygic, 111213111
9,13,Eparygic, 112131111
9,13,Ionygic, 121311111
9,13,Gyptygic, 213111111
9,13,Aerythygic, 131111112
9,14,Aeolacrygic, 311111112
9,14,Raptygic, 111111123
9,14,Gythygic, 111111231
9,14,Pyrygic, 111112311
9,14,Rycrygic, 111123111
9,14,Phrathygic, 111231111
9,14,Badygic, 112311111
9,14,Phrocrygic, 123111111
9,14,Starygic, 231111111
9,15,Kyrygic, 222111111
9,15,Sythygic, 221111112
9,15,Katycrygic, 211111122
9,15,Tharygic, 111111222
9,15,Sylygic, 111112221
9,15,Lothygic, 111122211
9,15,Darygic, 111222111
9,15,Monygic, 112221111
9,15,Styrygic, 122211111
9,16,Porygic, 221121111
9,16,Mocrygic, 211211112
9,16,Aeolyrygic, 112111122
9,16,Barygic, 121111221
9,16,Katarygic, 211112211
9,16,Aerocrygic, 111122112
9,16,Zanygic, 111221121
9,16,Aeolonygic, 112211211
9,16,Aeolanygic, 122112111
9,17,Kaptygic, 221111211
9,17,Sacrygic, 211112112
9,17,Padygic, 111121122
9,17,Epilygic, 111211221
9,17,Kynygic, 112112211
9,17,Stophygic, 121122111
9,17,Ionidygic, 211221111
9,17,Stonygic, 112211112
9,17,Stalygic, 122111121
9,18,Koptygic, 212121111
9,18,Raphygic, 121211112
9,18,Zycrygic, 212111121
9,18,Mycrygic, 121111212
9,18,Laptygic, 211112121
9,18,Pylygic, 111121212
9,18,Rodygic, 111212121
9,18,Epolygic, 112121211
9,18,Epidygic, 121212111
9,19,Phronygic, 211211211
9,19,Stynygic, 112112112
9,19,Zydygic, 121121121
10,1,Aerycryllian, 2111211111
10,1,Gadyllian, 1112111112
10,1,Solyllian, 1121111121
10,1,Zyphyllian, 1211111211
10,1,Garyllian, 2111112111
10,1,Soryllian, 1111121112
10,1,Godyllian, 1111211121
10,1,Epityllian, 1112111211
10,1,Ionyllian, 1121112111
10,1,Aeoryllian, 1211121111
10,2,Katoryllian, 3111111111
10,2,Dodyllian, 1111111113
10,2,Zogyllian, 1111111131
10,2,Madyllian, 1111111311
10,2,Dycryllian, 1111113111
10,2,Aeogyllian, 1111131111
10,2,Dydyllian, 1111311111
10,2,Thogyllian, 1113111111
10,2,Rygyllian, 1131111111
10,2,Bathyllian, 1311111111
10,3,Sydyllian, 2211111111
10,3,Katogyllian, 2111111112
10,3,Mixodyllian, 1111111122
10,3,Aeradyllian, 1111111221
10,3,Ryptyllian, 1111112211
10,3,Loptyllian, 1111122111
10,3,Kataphyllian, 1111221111
10,3,Phradyllian, 1112211111
10,3,Dagyllian, 1122111111
10,3,Katyllian, 1221111111
10,4,Gothyllian, 2121111111
10,4,Lythyllian, 1211111112
10,4,Bacryllian, 2111111121
10,4,Aerygyllian, 1111111212
10,4,Dathyllian, 1111112121
10,4,Boptyllian, 1111121211
10,4,Bagyllian, 1111212111
10,4,Mathyllian, 1112121111
10,4,Styptyllian, 1121211111
10,4,Zolyllian, 1212111111
10,5,Staptyllian, 2112111111
10,5,Danyllian, 1121111112
10,5,Goptyllian, 1211111121
10,5,Epocryllian, 2111111211
10,5,Rocryllian, 1111112112
10,5,Zyryllian, 1111121121
10,5,Sagyllian, 1111211211
10,5,Epinyllian, 1112112111
10,5,Katagyllian, 1121121111
10,5,Ragyllian, 1211211111
10,6,Thydyllian, 2111121111
10,6,Epiryllian, 1111211112
10,6,Lyryllian, 1112111121
10,6,Mogyllian, 1121111211
10,6,Katodyllian, 1211112111
11,1,Aerycratic, 21111111111
11,1,Monatic, 11111111112
11,1,Solatic, 11111111121
11,1,Zylatic, 11111111211
11,1,Mixolatic, 11111112111
11,1,Soratic, 11111121111
11,1,Godatic, 11111211111
11,1,Eptatic, 11112111111
11,1,Ionatic, 11121111111
11,1,Aeolatic, 11211111111
11,1,Thydatic, 12111111111
12,1,Chromatic, 111111111111";
            string[] listLines = rawData.Split('\n');

            scales = new List<Scale_CSV>();

            for (int i = 0; i < listLines.Length; i++)
            {
                if (listLines[i][0] == '#') continue;

                string ln = listLines[i];

                // n_notes (ScaleLength) [0], scale_no (ScaleNumber) [1], mode_name (ScaleName) [2], semitones (ScaleFormula) [3]
                string[] parts = ln.Split(',');

                Scale_CSV entry = new Scale_CSV();
                entry.ScaleLength = int.Parse(parts[0].Trim());
                entry.ScaleNumber = int.Parse(parts[1].Trim());
                entry.ScaleName = parts[2].Trim();
                entry.ScaleFormula = Utils.stringFormulaToArray(parts[3].Trim());

                scales.Add(entry);
            }

            listLines = null;
            rawData = "";
        }

        ~ScaleList()
        {
            this.Dispose();
        }


        public Scale_CSV findScaleFormula(string formula)
        {
            if (scales != null)
            {
                if (scales.Count > 0)
                {
                    for (int i = 0; i < scales.Count; i++)
                    {
                        if (scales[i].getFormulaString() == formula)
                        {
                            return scales[i];
                        }

                    }
                }
            }

            return new Scale_CSV();
        }

        public string getScaleNameFromFormula(string formula)
        {
            if (scales != null)
            {
                if (scales.Count > 0)
                {
                    Scale_CSV formulaLine = findScaleFormula(formula);
                    return formulaLine.ScaleName;
                }
            }
            return "";
        }

        public void Dispose()
        {
            if (this.scales != null)
            {
                this.scales.Clear();
                this.scales = null;
            }
        }
    }
}